import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      // {
      //   path: '/book-store',
      //   name: '::BookStore',
      //   iconClass: 'fas fa-book',
      //   order: 2,
      //   layout: eLayoutType.application,
      // },
      {
        path: '/books',
        name: '::Books',
        layout: eLayoutType.application,
        requiredPolicy: 'BookStore.Books',
      },
      {
        path: '/purchases',
        name: '::Purchases',
        layout: eLayoutType.application,
      },
      {
        path: '/storebooks',
        name: '::StoreBooks',
        layout: eLayoutType.application,
      },
    ]);
  };
}
