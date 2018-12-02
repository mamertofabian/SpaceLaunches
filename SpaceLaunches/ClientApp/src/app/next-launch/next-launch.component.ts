import { Component } from '@angular/core';
import { DataService } from '../core/data.service';

@Component({
  selector: 'app-next-launch',
  templateUrl: './next-launch.component.html',
  styleUrls: ['./next-launch.component.scss']
})
export class NextLaunchComponent {
  public launchList: LaunchList;

  constructor(private dataService: DataService) {
    this.dataService.getNextFiveLaunches()
      .subscribe(result => {
        this.launchList = result;
      }, error => console.error(error));
  }
}
