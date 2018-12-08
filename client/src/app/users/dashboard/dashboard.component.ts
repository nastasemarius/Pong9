import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-dashboard",
  templateUrl: "./dashboard.component.html",
  styleUrls: ["./dashboard.component.scss"]
})
export class DashboardComponent implements OnInit {
  public workspace: any;
  public users = [];

  constructor() {}

  ngOnInit() {
    this.workspace = {
      playCapacity: 150,
      tables: [{ number: 1 }, { number: 2 }, { number: 3 }, { number: 4 }],
      name: "LEVI9"
    };

    this.users = [
      {
        username: "uli1994",
        status: 2,
        avatarUrl:
          "https://www.whitehouse.gov/wp-content/uploads/2017/12/44_barack_obama1.jpg"
      },
      { username: "johndoe25", status: "offline" },
      {
        username: "mary112",
        status: 2,
        avatarUrl:
          "https://media.gettyimages.com/photos/ace-frehley-of-kiss-studio-portrait-united-states-1996-picture-id558874613?s=612x612"
      },
      { username: "vg112", status: "playing" },
      {
        username: "dds115",
        status: 1,
        avatarUrl: "https://i.imgur.com/KGbJY0A.jpg"
      }
    ];
  }

  mapStatusToColor(status) {
    switch (status) {
      case 2:
        return "yellow";
      case 0:
        return "green";
      case 1:
        return "red";
      default:
        return "grey";
    }
  }
}
