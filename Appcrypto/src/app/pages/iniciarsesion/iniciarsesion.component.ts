import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-iniciarsesion',
  templateUrl: './iniciarsesion.component.html',
  styleUrls: ['./iniciarsesion.component.css']
})
export class IniciarsesionComponent implements OnInit {
  form: any;
  mail= new FormControl('',[],[]);
  password= new FormControl('',[Validators.required, Validators.minLength(8)])
  constructor() { }

  ngOnInit(): void {
  }
}



  

