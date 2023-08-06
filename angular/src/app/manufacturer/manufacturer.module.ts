import { NgModule } from '@angular/core';

import { ManufacturerRoutingModule } from './manufacturer-routing.module';
import { ManufacturerComponent } from './manufacturer.component';
import { SharedModule } from '../shared/shared.module';
import { ManufacturerDetailsComponent } from './manufacturer-details/manufacturer-details.component';
import { CreateUpdateManufacturerComponent } from './create-update-manufacturer/create-update-manufacturer.component';


@NgModule({
  declarations: [
    ManufacturerComponent,
    ManufacturerDetailsComponent,
    CreateUpdateManufacturerComponent
  ],
  imports: [
    SharedModule,
    ManufacturerRoutingModule
  ]
})
export class ManufacturerModule { }
