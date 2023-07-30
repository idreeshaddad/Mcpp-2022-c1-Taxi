import { AuthGuard, PermissionGuard } from '@abp/ng.core';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateUpdatePassengerComponent } from './create-update-passenger/create-update-passenger.component';
import { PassengerComponent } from './passenger.component';

const routes: Routes = [
  { path: '', component: PassengerComponent, canActivate: [AuthGuard, PermissionGuard] },
  { path: 'create', component: CreateUpdatePassengerComponent, canActivate: [AuthGuard, PermissionGuard] },
  { path: 'edit/:id', component: CreateUpdatePassengerComponent, canActivate: [AuthGuard, PermissionGuard] },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PassengerRoutingModule { }
