import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ManufacturerRoutingModule } from './manufacturer-routing.module';
import { ManufacturerComponent } from './manufacturer.component';


@NgModule({
  declarations: [
    ManufacturerComponent
  ],
  imports: [
    CommonModule,
    ManufacturerRoutingModule
  ]
})
export class ManufacturerModule { }
