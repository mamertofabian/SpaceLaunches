import { Component, OnInit } from '@angular/core';
import { DataService } from '../core/data.service';

@Component({
  selector: 'app-rocket-list',
  templateUrl: './rocket-list.component.html',
  styleUrls: ['./rocket-list.component.scss']
})
export class RocketListComponent {
  public rocketList: RocketList;

  constructor(private dataService: DataService) {
    this.dataService.getFiveRockets()
      .subscribe(result => {
        this.rocketList = result;
      }, error => console.error(error));
  }
}
