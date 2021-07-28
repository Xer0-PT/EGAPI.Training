import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'BookStore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44330',
    redirectUri: baseUrl,
    clientId: 'BookStore_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone BookStore',
  },
  apis: {
    default: {
      url: 'https://localhost:44304',
      rootNamespace: 'Acme.BookStore',
    },
    store: {
      url: 'https://localhost:44372',
      rootNamespace: 'Acme.BookStore.Store',
    }
  },
} as Environment;
