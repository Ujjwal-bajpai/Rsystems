import { NgFor, NgIf } from '@angular/common';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-customer-list',
  standalone: true,
  imports: [NgFor,NgIf],
  templateUrl: './customer-list.component.html',
  styleUrl: './customer-list.component.css'
})
export class CustomerListComponent implements OnInit {

  employeeList:any[] = [];

  constructor() {


  }
  ngOnInit() {
  }

}
