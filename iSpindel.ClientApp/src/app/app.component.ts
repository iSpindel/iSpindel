import { Component } from '@angular/core';
import { NotifyService } from 'src/services/notify.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'iSpindel Overview';
  screenWidth: number;

  constructor(notifyService: NotifyService) {
    this.screenWidth = window.innerWidth;
    window.onresize = () => {
      this.screenWidth = window.innerWidth;
    };
    notifyService.StartConnection();

  }
}
