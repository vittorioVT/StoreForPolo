import { Component } from '@angular/core';
@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css',
        './styles.css']
})
export class AppComponent {
    welcome: string;
    constructor() {
        this.welcome = "Моя вторая попытка с Angular Material";
    }


}