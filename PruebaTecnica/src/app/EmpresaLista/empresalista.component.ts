import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-empresa-lista',
  templateUrl: './empresalista.component.html'
})
export class EmpresaListaComponent implements OnInit {

  empresas: any[] = [];
  readonly api = 'https://localhost:5001/api/EmpresasControllers/ObtenerEmpresas';

  constructor(private http: HttpClient, private router: Router) {}

  ngOnInit(): void {
    this.http.get<any[]>(`${this.api}`).subscribe(data => this.empresas = data);
  }

  eliminar(id: number): void {
    if (!confirm('¿Eliminar esta empresa?')) return;
    this.http.delete(`https://localhost:5001/api/EmpresasControllers/Elminar?Id=${id}`).subscribe(() =>
      this.empresas = this.empresas.filter(e => e.id !== id)
    );
  }
}