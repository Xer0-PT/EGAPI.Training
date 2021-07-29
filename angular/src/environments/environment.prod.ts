import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'BookStore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44357',
    // issuer: 'https://localhost:44354',
    redirectUri: baseUrl,
    clientId: 'BookStore_App',
    responseType: 'code',
    scope: 'offline_access BookStore',
  },
  apis: {
    default: {
      url: 'https://localhost:44357',
      // url: 'https://localhost:44354',
      rootNamespace: 'BookStore',
    },
  },
} as Environment;
