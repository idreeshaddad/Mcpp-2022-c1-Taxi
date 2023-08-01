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
        order: 10,
        layout: eLayoutType.application,
      },
      {
        path: '/passengers',
        name: '::Menu:Passengers',
        iconClass: 'fas fa-wheelchair',
        order: 20,
        layout: eLayoutType.application,
        requiredPolicy: 'Taxi.Passengers',
      },
      ,
      {
        path: '/manufacturers',
        name: '::Menu:Manufacturers',
        iconClass: 'fas fa-industry',
        order: 30,
        layout: eLayoutType.application,
        requiredPolicy: 'Taxi.Manufacturers',
      }
    ]);
  };
}
