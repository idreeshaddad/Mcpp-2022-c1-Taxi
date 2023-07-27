import { ListService, LocalizationService, PagedResultDto } from '@abp/ng.core';
import { Confirmation, ConfirmationService } from '@abp/ng.theme.shared';
import { Component, OnInit } from '@angular/core';
import { PassengerDto, PassengerService } from '@proxy/passengers';

@Component({
  selector: 'app-passenger',
  templateUrl: './passenger.component.html',
  styleUrls: ['./passenger.component.scss'],
  providers: [ListService]
})
export class PassengerComponent implements OnInit {
  passenger = { items: [], totalCount: 0 } as PagedResultDto<PassengerDto>;

  constructor(
    public readonly list: ListService,
    private passengerSvc: PassengerService,
    private confirmation: ConfirmationService,
    private localizationService: LocalizationService) { }

  ngOnInit() {
    const passengerStreamCreator = (query) => this.passengerSvc.getList(query);

    this.list.hookToQuery(passengerStreamCreator).subscribe((response) => {
      this.passenger = response;
    });
  }

  delete(passenger: PassengerDto) {

    const deleteMsg = this.localizationService.instant(
      '::AreYouSureToDelete',
      passenger.fullName
    );

    this.confirmation.warn(deleteMsg, '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.passengerSvc.delete(passenger.id).subscribe(() => this.list.get());
      }
    });
  }
}
