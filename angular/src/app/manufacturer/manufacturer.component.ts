import { ListService, LocalizationService, PagedResultDto } from '@abp/ng.core';
import { Confirmation, ConfirmationService } from '@abp/ng.theme.shared';
import { Component, OnInit } from '@angular/core';
import { ManufacturerDto, ManufacturerService } from '@proxy/manufacturers';

@Component({
  selector: 'app-manufacturer',
  templateUrl: './manufacturer.component.html',
  styleUrls: ['./manufacturer.component.scss'],
  providers: [ListService]
})
export class ManufacturerComponent implements OnInit {

  manufacturer = { items: [], totalCount: 0 } as PagedResultDto<ManufacturerDto>;

  constructor(
    public readonly list: ListService,
    private manSvc: ManufacturerService,
    private confirmation: ConfirmationService,
    private localizationService: LocalizationService) { }

  ngOnInit() {
    const passengerStreamCreator = (query) => this.manSvc.getList(query);

    this.list.hookToQuery(passengerStreamCreator).subscribe((response) => {
      this.manufacturer = response;
    });
  }

  delete(manufacturer: ManufacturerDto) {

    const deleteMsg = this.localizationService.instant(
      '::AreYouSureToDeleteManufacturer',
      manufacturer.name
    );

    this.confirmation.warn(deleteMsg, '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.manSvc.delete(manufacturer.id).subscribe(() => this.list.get());
      }
    });
  }
}
