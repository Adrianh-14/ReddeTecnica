import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-empresa-crear',
  templateUrl: './empresacrear.component.html'
})
export class EmpresaCrearComponent {

  empresa: any = {};
  enviado = false;
  buscando = false;
  readonly api = 'https://localhost:5001/api/EmpresasControllers';
  readonly dgiiApi = 'https://localhost:5001/api/ConsultasDGI/ObtenerDatos';

  constructor(private http: HttpClient, private router: Router) {}

  consultarRNC(): void {
    if (!this.empresa.rnc) return;
    this.buscando = true;
    this.http.get<any>(`${this.dgiiApi}?Rnc=${this.empresa.rnc}`).subscribe(
      data => {
        this.empresa.nombre = data.nombre;
        this.empresa.nombreComercial = data.nonmbreoRazonSocial;
        this.empresa.actividadEconomica = data.actividadEconomica;
        this.empresa.categoria = data.categoria;
        this.empresa.esquemaPagos = data.formatoDePago;
        this.empresa.estado = data.status ? 'Activo' : 'Inactivo';
        this.buscando = false;
      },
      () => {
        alert('No se encontró el RNC.');
        this.buscando = false;
      }
    );
  }

  guardar(): void {
    this.enviado = true;
    if (!this.empresa.rnc || !this.empresa.nombre) return;
    this.http.post(`${this.api}/AgregarEmpresas`, this.empresa).subscribe(() =>
      this.router.navigate(['/'])
    );
  }

  cancelar(): void {
    this.empresa = {};
    this.enviado = false;
  }
}