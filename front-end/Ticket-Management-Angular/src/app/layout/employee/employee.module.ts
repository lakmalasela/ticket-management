import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { PageHeaderModule } from '../../shared';

import { EmployeeRoutingModule } from './employee-routing.module';
import { EmployeeComponent } from './employee.component';

@NgModule({
    imports: [CommonModule, EmployeeRoutingModule, PageHeaderModule],
    declarations: [EmployeeComponent]
})
export class EmployeeModule {}
