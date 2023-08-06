import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ManufacturerDto, ManufacturerService } from '@proxy/manufacturers';

@Component({
  selector: 'app-manufacturer-details',
  templateUrl: './manufacturer-details.component.html',
  styleUrls: ['./manufacturer-details.component.scss']
})
export class ManufacturerDetailsComponent implements OnInit {

  manufacturerId: number = 0;
  manufacturer: ManufacturerDto;

  constructor(
    private manSvc: ManufacturerService,
    private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {

    this.setManufacturerId();

    if (this.manufacturerId != 0) {

      this.loadManufacturer();
    }
  }

  setManufacturerId(): void {

    if (this.activatedRoute.snapshot.paramMap.get('id')) {
      this.manufacturerId = Number(this.activatedRoute.snapshot.paramMap.get('id'));
    }
  }

  loadManufacturer() {

    this.manSvc.get(this.manufacturerId).subscribe({
      next: (manufacturerFromApi: ManufacturerDto) => {
        this.manufacturer = manufacturerFromApi;
      }
    });
  }
}

