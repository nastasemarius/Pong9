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
      { username: 'uli1994', status: 'available', avatarUrl: "https://www.whitehouse.gov/wp-content/uploads/2017/12/44_barack_obama1.jpg" },
      { username: 'johndoe25', status: 'offline' },
      { username: 'mary112', status: 'wantsToPlay', avatarUrl: "https://media.gettyimages.com/photos/ace-frehley-of-kiss-studio-portrait-united-states-1996-picture-id558874613?s=612x612" },
      { username: 'vg112', status: 'playing' },
      { username: 'dds115', status: 'busy', avatarUrl: 'https://i.imgur.com/KGbJY0A.jpg' },
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
