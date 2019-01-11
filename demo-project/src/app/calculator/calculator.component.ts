import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.scss']
})
export class CalculatorComponent implements OnInit {

  constructor() { }
labelText: number;
  ngOnInit() {
  }

  add() {
    const Number1: string = (document.getElementById('Num1') as HTMLInputElement).value;
    const Number2: string = (document.getElementById('Num2') as HTMLInputElement).value;
    this.labelText =  Number(Number1) + Number(Number2);
  }

  sub() {
    const Number1: string = (document.getElementById('Num1') as HTMLInputElement).value;
    const Number2: string = (document.getElementById('Num2') as HTMLInputElement).value;
    this.labelText =  Number(Number1) - Number(Number2);
  }

  mul() {
    const Number1: string = (document.getElementById('Num1') as HTMLInputElement).value;
    const Number2: string = (document.getElementById('Num2') as HTMLInputElement).value;
    this.labelText =  Number(Number1) * Number(Number2);
  }

  div() {
    const Number1: string = (document.getElementById('Num1') as HTMLInputElement).value;
    const Number2: string = (document.getElementById('Num2') as HTMLInputElement).value;
    this.labelText =  Number(Number2) === 0 ? 0 : Number(Number1) / Number(Number2);
  }

}
