import { Component, OnInit } from '@angular/core';
import { routerTransition } from '../../router.animations';

@Component({
    selector: 'app-form',
    templateUrl: './employee.component.html',
    styleUrls: ['./employee.component.scss','./employee.css'],
    animations: [routerTransition()]
})
export class EmployeeComponent implements OnInit {
    constructor() {}

    ngOnInit() {}
}
