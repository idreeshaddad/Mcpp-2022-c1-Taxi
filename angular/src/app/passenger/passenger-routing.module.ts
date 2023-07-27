import { AuthGuard, PermissionGuard } from '@abp/ng.core';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PassengerComponent } from './passenger.component';

const routes: Routes = [
  { path: '', component: PassengerComponent, canActivate: [AuthGuard, PermissionGuard] }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PassengerRoutingModule { }
