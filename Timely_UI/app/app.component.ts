import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  onStartActiveSection = false;
  onStopActiveSection = false;

  toggleStartButton() {
    this.onStartActiveSection = !this.onStartActiveSection;
  }

  toggleStopButton() {
    this.onStopActiveSection = !this.onStopActiveSection;
  }
}
