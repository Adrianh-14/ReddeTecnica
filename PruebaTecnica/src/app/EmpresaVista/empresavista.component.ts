import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-empresa-vista',
  templateUrl: './empresavista.component.html'
})
export class EmpresaVistaComponent implements OnInit {

  empresa: any = {};
  readonly api = 'https://localhost:5001/api/EmpresasControllers';

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {}

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    this.http.get(`${this.api}/Obtener?Id=${id}`).subscribe(data => this.empresa = data);
  }
}