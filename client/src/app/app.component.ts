import { Component, OnInit } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Pong9';

  private hubConnection: HubConnection;
  message = '';
  userId: number;
  messages: string[] = [];

  constructor() { }

  ngOnInit() {
    this.hubConnection = new HubConnectionBuilder().withUrl('/notification').build();

    this.hubConnection
      .start()
      .then(() => console.log('Connection started!'))
      .catch(err => console.log('Error while establishing connection :('));

      this.hubConnection.on('receive', (userId, receivedMessage) => {
        const text = `${userId}: ${receivedMessage}`;
        console.log(text);
      });

    }

}

