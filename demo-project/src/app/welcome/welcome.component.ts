import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-welcome',
  templateUrl: './welcome.component.html',
  styleUrls: ['./welcome.component.scss']
})
export class WelcomeComponent implements OnInit {

  constructor() { }
  labelText: string;
  ngOnInit() {
  }

  clickMe() {
    const fName: string = (document.getElementById('fName') as HTMLInputElement).value;
    const lName: string = (document.getElementById('lName') as HTMLInputElement).value;
    this.labelText = 'Hello ' + fName.toUpperCase() + ' ' + lName.toUpperCase();
  }

}
