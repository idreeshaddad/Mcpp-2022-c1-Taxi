import { ConfirmationService } from '@abp/ng.theme.shared';
import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ManufacturerDto, ManufacturerService } from '@proxy/manufacturers';

@Component({
  selector: 'app-create-update-manufacturer',
  templateUrl: './create-update-manufacturer.component.html',
  styleUrls: ['./create-update-manufacturer.component.scss']
})
export class CreateUpdateManufacturerComponent implements OnInit {

  manufacturerForm: FormGroup;
  manufacturerId: number = 0;

  constructor(
    private fb: FormBuilder,
    private manSvc: ManufacturerService,
    private router: Router,
    private confirmation: ConfirmationService,
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit(): void {

    this.setManId();

    this.buildForm();

    if (this.manufacturerId != 0) {

      this.loadMan();
    }

  }

  loadMan() {

    this.manSvc.get(this.manufacturerId).subscribe({
      next: (manFromApi: ManufacturerDto) => {
        this.manufacturerForm.patchValue(manFromApi);
      },
      error: (err: HttpErrorResponse) => {
        this.confirmation.error(err.message, err.name, { hideYesBtn: true, cancelText: 'Ok' });
      }
    });
  }

  buildForm() {

    this.manufacturerForm = this.fb.group({
      id: [0],
      name: ['', Validators.required],
    });

  }

  setManId(): void {

    if (this.activatedRoute.snapshot.paramMap.get('id')) {
      this.manufacturerId = Number(this.activatedRoute.snapshot.paramMap.get('id'));
    }
  }

  submitForm(): void {

    if (this.manufacturerForm.valid) {

      if (this.manufacturerId == 0) {
        this.manSvc.create(this.manufacturerForm.value).subscribe({
          next: (manDetailsFromApi: ManufacturerDto) => {
            this.router.navigate(['/manufacturers']);
          }
        });
      }
      else {

        this.manSvc.update(this.manufacturerId, this.manufacturerForm.value).subscribe({
          next: (manDetailsFromApi: ManufacturerDto) => {
            this.router.navigate(['/manufacturers']);
          }
        });
      }

    }
  }
}

