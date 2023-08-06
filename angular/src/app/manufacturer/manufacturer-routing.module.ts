import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ManufacturerComponent } from './manufacturer.component';
import { ManufacturerDetailsComponent } from './manufacturer-details/manufacturer-details.component';
import { AuthGuard, PermissionGuard } from '@abp/ng.core';
import { CreateUpdateManufacturerComponent } from './create-update-manufacturer/create-update-manufacturer.component';

const routes: Routes = [
  { path: '', component: ManufacturerComponent, canActivate: [AuthGuard, PermissionGuard] },
  { path: 'details/:id', component: ManufacturerDetailsComponent, canActivate: [AuthGuard, PermissionGuard] },
  { path: 'create', component: CreateUpdateManufacturerComponent, canActivate: [AuthGuard, PermissionGuard] },
  { path: 'edit/:id', component: CreateUpdateManufacturerComponent, canActivate: [AuthGuard, PermissionGuard] },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ManufacturerRoutingModule { }
