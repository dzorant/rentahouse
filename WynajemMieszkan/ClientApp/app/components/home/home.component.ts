import { Component } from '@angular/core';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    title: string = "to jest title komponentu";
    isCool: boolean = true;
    year: number = 2017;
}
