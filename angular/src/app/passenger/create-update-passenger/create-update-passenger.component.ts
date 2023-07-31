import { ConfirmationService } from '@abp/ng.theme.shared';
import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CreateUpdatePassengerDto, PassengerDetailsDto, PassengerService } from '@proxy/passengers';

@Component({
  selector: 'app-create-update-passenger',
  templateUrl: './create-update-passenger.component.html',
  styleUrls: ['./create-update-passenger.component.scss']
})
export class CreateUpdatePassengerComponent implements OnInit {

  passengerForm: FormGroup;
  passengerId: number = 0;

  constructor(
    private fb: FormBuilder,
    private passengerSvc: PassengerService,
    private router: Router,
    private confirmation: ConfirmationService,
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit(): void {

    this.setPassengerId();

    this.buildForm();

    if (this.passengerId != 0) {

      this.loadPassenger();
    }

  }

  loadPassenger() {

    this.passengerSvc.get(this.passengerId).subscribe({
      next: (passengerFromApi: PassengerDetailsDto) => {
        this.passengerForm.patchValue(passengerFromApi);
      },
      error: (err: HttpErrorResponse) => {
        this.confirmation.error(err.message, err.name, { hideYesBtn: true, cancelText: 'Ok' });
      }
    });
  }

  buildForm() {

    this.passengerForm = this.fb.group({
      id: [0],
      fullName: ['', Validators.required],
      phoneNumber: ['', Validators.required],
    });

  }

  setPassengerId(): void {

    if (this.activatedRoute.snapshot.paramMap.get('id')) {
      this.passengerId = Number(this.activatedRoute.snapshot.paramMap.get('id'));
    }
  }

  submitForm(): void {

    if (this.passengerForm.valid) {

      if (this.passengerId == 0) {
        this.passengerSvc.create(this.passengerForm.value).subscribe({
          next: (passengerDetailsFromApi: PassengerDetailsDto) => {
            this.router.navigate(['/passengers']);
          }
        });
      }
      else {

        this.passengerSvc.update(this.passengerId, this.passengerForm.value).subscribe({
          next: (passengerDetailsFromApi: PassengerDetailsDto) => {
            this.router.navigate(['/passengers']);
          }
        });
      }

    }
  }
}

