import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DemoTwoWayBinding';
  name:string="Raj";
  OnClick():void
  {
    console.log(this.name);
  }
}
