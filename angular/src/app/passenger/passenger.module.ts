import { NgModule } from '@angular/core';

import { PassengerRoutingModule } from './passenger-routing.module';
import { PassengerComponent } from './passenger.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    PassengerComponent
  ],
  imports: [
    SharedModule,
    PassengerRoutingModule
  ]
})
export class PassengerModule { }
