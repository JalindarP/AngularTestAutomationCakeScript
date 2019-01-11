import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {CalculatorComponent} from './calculator/calculator.component';
import {WelcomeComponent} from './welcome/welcome.component';

const routes: Routes = [{path: 'welcome', component: WelcomeComponent},
{path: 'calculator', component: CalculatorComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
