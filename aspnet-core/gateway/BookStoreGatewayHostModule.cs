using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using StackExchange.Redis;
using System;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using Volo.Abp.Autofac;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Http.Client.IdentityModel.Web;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.PermissionManagement.IdentityServer;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using Volo.Blogging;
using Acme.BookStore;
using Acme.BookStore.Store;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.IO;
using Microsoft.AspNetCore.Http;
using Volo.Abp.AspNetCore.Mvc.AntiForgery;
using Volo.Abp.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace gateway
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(AbpIdentityHttpApiClientModule),
        
        
        typeof(BookStoreHttpApiModule),
        typeof(BookStoreHttpApiClientModule),


        typeof(StoreHttpApiModule),
        typeof(StoreHttpApiClientModule),

        
        typeof(AbpPermissionManagementEntityFrameworkCoreModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpPermissionManagementHttpApiModule),
        typeof(AbpSettingManagementEntityFrameworkCoreModule),
        typeof(BloggingApplicationContractsModule),
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpPermissionManagementDomainIdentityServerModule),
        typeof(AbpHttpClientIdentityModelWebModule),
        typeof(AbpTenantManagementApplicationContractsModule),
        typeof(AbpTenantManagementHttpApiModule),
        typeof(AbpTenantManagementHttpApiClientModule),
        typeof(AbpTenantManagementEntityFrameworkCoreModule),
        typeof(AbpFeatureManagementEntityFrameworkCoreModule),
        typeof(AbpFeatureManagementApplicationModule),
        typeof(AbpFeatureManagementHttpApiModule),
        typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
        )]
    public class BookStoreGatewayHostModule : AbpModule
    {
        private const string DefaultCorsPolicyName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            context.Services.AddCors(options =>
            {
                options.AddPolicy(DefaultCorsPolicyName, builder =>
                {
                    builder
                        .WithOrigins(
                            configuration["App:CorsOrigins"]
                                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                .Select(o => o.RemovePostFix("/"))
                                .ToArray()
                        )
                        .WithAbpExposedHeaders()
                        .SetIsOriginAllowedToAllowWildcardSubdomains()
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                });
            });

            context.Services.AddAuthentication("Bearer")
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = configuration["AuthServer:Authority"];
                    options.ApiName = configuration["AuthServer:ApiName"];
                    options.RequireHttpsMetadata = Convert.ToBoolean(configuration["AuthServer:RequireHttpsMetadata"]);
                });


            Configure<AbpAntiForgeryOptions>(options =>
            {
                options.AutoValidate = true;
            });


            // Swagger especifico para ocelot <-- A funcionar
            //context.Services.AddSwaggerForOcelot(configuration);


            // Config Swagger do GitHub ABP
            context.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "BookStore Gateway API", Version = "v1" });
                options.DocInclusionPredicate((docName, description) => true);
                options.CustomSchemaIds(type => type.FullName);
            });


            // Config Swagger como a dos restantes projetos
            //context.Services.AddAbpSwaggerGenWithOAuth(
            //    configuration["AuthServer:Authority"],
            //    new Dictionary<string, string>
            //    {
            //        {"Gateway", "BookStore Gateway API"},
            //        {"Book", "Book API" },
            //        {"Store", "Store API" }
            //    },
            //    options =>
            //    {
            //        options.SwaggerDoc("v1", new OpenApiInfo { Title = "BookStore Gateway API", Version = "v1" });
            //        options.DocInclusionPredicate((docName, description) => true);
            //        options.CustomSchemaIds(type => type.FullName);
            //    });


            context.Services.AddOcelot(configuration);

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseNpgsql();
            });

            context.Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration["Redis:Configuration"];
            });

            var redis = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]);
            context.Services.AddDataProtection()
                .PersistKeysToStackExchangeRedis(redis, "Gateway-DataProtection-Keys");
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();

            
            // Use's do GitHub ABP
            app.UseCorrelationId();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAbpClaimsMap();
            app.UseMultiTenancy();

            //app.UseHttpsRedirection();

            // Swagger especifico para ocelot <-- A funcionar
            //app.UseSwaggerForOcelotUI(opt =>
            //{
            //    opt.PathToSwaggerGenerator = "/swagger/docs";
            //});


            // Use Swagger do GitHub ABP
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "BookStore Gateway API");
                //options.SwaggerEndpoint("https://localhost:44304/swagger/v1/swagger.json", "Book API");
                //options.SwaggerEndpoint("https://localhost:44372/swagger/v1/swagger.json", "Store API");
            });



            // MapWhen do GitHub ABP
            app.MapWhen(
                ctx => ctx.Request.Path.ToString().StartsWith("/api/abp/") ||
                       ctx.Request.Path.ToString().StartsWith("/Abp/") ||
                       //ctx.Request.Path.ToString().StartsWith("/api/permission-management/") ||
                       //ctx.Request.Path.ToString().StartsWith("/api/feature-management/") ||
                       //ctx.Request.Path.ToString().StartsWith("/api/app/") ||
                       //ctx.Request.Path.ToString().StartsWith("/gateway/") ||
                       ctx.Request.Path.ToString().TrimEnd('/').Equals(""),
                app2 =>
                {
                    app2.UseRouting();
                    app2.UseConfiguredEndpoints();
                }
            );

            app.UseOcelot().Wait();
        }
    }
}