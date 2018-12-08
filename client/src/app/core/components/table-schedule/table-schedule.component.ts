import { Component, OnInit, Input } from '@angular/core';
import * as moment from 'moment';
@Component({
  selector: 'app-table-schedule',
  templateUrl: './table-schedule.component.html',
  styleUrls: ['./table-schedule.component.scss']
})



export class TableScheduleComponent implements OnInit {

  @Input('tableInfo') tableInfo: any;
  public availableHours: any[] = [];
  constructor() {
    this.initDailyTableHours();
  }

  initDailyTableHours() {

    let workStart = 9;
    let workEnd = 20;
    for (workStart; workStart < workEnd; workStart++) {
      let current = moment().startOf('day').add(workStart, 'h');
      this.availableHours.push({
        disabled: moment().startOf('day').add(workStart, 'h').isBefore(moment.utc().startOf('hour')),
        intervalStart: current.format('HH:mm:ss'),
        intervalEnd: current.add(1, 'h').format('HH:mm:ss'),
      })
    }
  }

  bookTable(selectedHours) {
    const bookData = {
      tableData: { ...this.tableInfo },
      bookingHours: selectedHours
    }
    //TODO: CONNECT TO DATABASE TO SHOW ALREADY BOOKED HOURS
    console.log(bookData);
  }

  unableToBook(selectedHours) {
    return selectedHours.length === 0 || selectedHours.length > 2;
  }

  ngOnInit() {
  }

}
