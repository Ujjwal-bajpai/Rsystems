import { Routes } from '@angular/router';
import { CustomerListComponent } from './customer-list/customer-list.component';

export const routes: Routes = [
    { path: '', 'title':'About',component: CustomerListComponent },
];
