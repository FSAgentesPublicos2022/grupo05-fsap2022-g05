import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ingreso',
  templateUrl: './ingreso.component.html',
  styleUrls: ['./ingreso.component.css'],
})
export class IngresoComponent implements OnInit {
  

  saldo: number = 0;
  inputValue: any;

  deposito() {
    console.log(this.inputValue);
    
    if (!isNaN(this.inputValue)) {
      this.saldo += this.inputValue;//acumulador
      this.inputValue=null; 
    }
  }

  ngOnInit(): void {}
}
