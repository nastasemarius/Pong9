import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  public workspace: any;
  public users = [];

  constructor() {

    this.workspace = {
      playCapacity: 150,
      tables: [{ number: 1 }, { number: 2 }, { number: 3 }, { number: 4 }],
      name: 'LEVI9'
    }
    this.users = [
      { username: 'uli1994', status: 'available' },
      { username: 'johndoe25', status: 'offline' },
      { username: 'mary112', status: 'wantsToPlay' },
      { username: 'vg112', status: 'playing' },
      { username: 'dds115', status: 'busy' },
    ]
  }

  ngOnInit() {

  }

  mapStatusToColor(status) {
    switch (status) {
      case 'wantsToPlay': return 'yellow';
      case 'available': return 'green';
      case 'busy': return 'red';
      case 'playing': return 'orange'
      case 'offline': return 'grey';
      default: return 'grey';
    }
  }

}
