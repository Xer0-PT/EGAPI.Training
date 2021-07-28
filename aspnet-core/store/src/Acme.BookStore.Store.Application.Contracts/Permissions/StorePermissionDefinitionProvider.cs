using Acme.BookStore.Store.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Store.Permissions
{
    public class StorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(StorePermissions.GroupName, L("Permission:Store"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<StoreResource>(name);
        }
    }
}