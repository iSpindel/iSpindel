import { Component } from '@angular/core';
import { NotifyService } from 'src/services/notify.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'iSpindel Datenübersicht';
  screenWidth: number;

  constructor(private notifyService: NotifyService) {
    this.screenWidth = window.innerWidth;
    window.onresize = () => {
      this.screenWidth = window.innerWidth;
    };
  }

  ngOnInit() {
    this.notifyService.StartConnection();
  }
}
