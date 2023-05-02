import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'PetShop',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44333/',
    redirectUri: baseUrl,
    clientId: 'PetShop_App',
    responseType: 'code',
    scope: 'offline_access PetShop',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44333',
      rootNamespace: 'PetShop',
    },
  },
} as Environment;