import { ConfirmationService } from '@abp/ng.theme.shared';
import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CreateUpdatePassengerDto, PassengerDetailsDto, PassengerService } from '@proxy/passengers';

@Component({
  selector: 'app-create-update-passenger',
  templateUrl: './create-update-passenger.component.html',
  styleUrls: ['./create-update-passenger.component.scss']
})
export class CreateUpdatePassengerComponent implements OnInit {

  passenger: CreateUpdatePassengerDto;
  passengerForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private passengerSvc: PassengerService,
    private router: Router,
    private confirmation: ConfirmationService
  ) { }

  ngOnInit(): void {

    this.buildForm();
  }

  buildForm() {

    this.passengerForm = this.fb.group({
      id: [0],
      fullName: ['', Validators.required],
      phoneNumber: ['', Validators.required],
    });

  }

  createPassenger(): void {

    if (this.passengerForm.valid) {

      this.passengerSvc.create(this.passengerForm.value).subscribe({
        next: (passengerDetailsFromApi: PassengerDetailsDto) => {
          this.router.navigate(['/passengers']);
        },
        error: (err: HttpErrorResponse) => {
          this.confirmation.error(err.message, err.name, { hideYesBtn: true, cancelText: 'Ok' });
        }
      });
    }
  }
}
