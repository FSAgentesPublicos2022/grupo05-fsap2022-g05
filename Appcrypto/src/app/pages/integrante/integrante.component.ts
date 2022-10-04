import { Component, OnInit } from '@angular/core';
import { ActivatedRoute,Params } from '@angular/router';

@Component({
  selector: 'app-integrante',
  templateUrl: './integrante.component.html',
  styleUrls: ['./integrante.component.css']
})
export class IntegranteComponent implements OnInit {
  integrante: any;

  constructor(private rutaActiva:ActivatedRoute) { }

  ngOnInit(): void {
    this.rutaActiva.params.subscribe(
      (params:Params)=>{
        this.integrante= params['id'];
      }
      );
  }

}
