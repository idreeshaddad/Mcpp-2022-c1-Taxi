import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PassengerDetailsDto, PassengerService } from '@proxy/passengers';

@Component({
  selector: 'app-passenger-details',
  templateUrl: './passenger-details.component.html',
  styleUrls: ['./passenger-details.component.scss']
})
export class PassengerDetailsComponent implements OnInit {

  passengerId: number = 0;
  passenger: PassengerDetailsDto;

  constructor(
    private passengerSvc: PassengerService,
    private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {

    this.setPassengerId();

    if (this.passengerId != 0) {

      this.loadPassenger();
    }
  }

  setPassengerId(): void {

    if (this.activatedRoute.snapshot.paramMap.get('id')) {
      this.passengerId = Number(this.activatedRoute.snapshot.paramMap.get('id'));
    }
  }

  loadPassenger() {

    this.passengerSvc.get(this.passengerId).subscribe({
      next: (passengerFromApi: PassengerDetailsDto) => {
        this.passenger = passengerFromApi;
      }
    });
  }
}
