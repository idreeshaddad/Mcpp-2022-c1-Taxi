import { NgModule } from '@angular/core';

import { PassengerRoutingModule } from './passenger-routing.module';
import { PassengerComponent } from './passenger.component';
import { SharedModule } from '../shared/shared.module';
import { CreateUpdatePassengerComponent } from './create-update-passenger/create-update-passenger.component';
import { PassengerDetailsComponent } from './passenger-details/passenger-details.component';


@NgModule({
  declarations: [
    PassengerComponent,
    CreateUpdatePassengerComponent,
    PassengerDetailsComponent
  ],
  imports: [
    SharedModule,
    PassengerRoutingModule
  ]
})
export class PassengerModule { }
