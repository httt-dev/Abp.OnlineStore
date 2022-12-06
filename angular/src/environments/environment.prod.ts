import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'OnlineStore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44339/',
    redirectUri: baseUrl,
    clientId: 'OnlineStore_App',
    responseType: 'code',
    scope: 'offline_access OnlineStore',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44371',
      rootNamespace: 'Abp.OnlineStore',
    },
  },
} as Environment;
