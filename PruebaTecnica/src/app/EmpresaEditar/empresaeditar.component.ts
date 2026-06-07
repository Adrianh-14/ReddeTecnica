import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-empresa-editar',
  templateUrl: './empresaEditar.component.html'
})
export class EmpresaEditarComponent implements OnInit {

  empresa: any = {};
  enviado = false;
  readonly api = 'https://localhost:5001/api/EmpresasControllers';

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {}

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    this.http.get(`${this.api}/Obtener?Id=${id}`).subscribe(data => this.empresa = data);
  }

  guardar(): void {
    this.enviado = true;
    if (!this.empresa.nombre) return;
    this.http.put(`${this.api}/Actualizar`, this.empresa).subscribe(() =>
      this.router.navigate(['/'])
    );
  }

  cancelar(): void {
    this.router.navigate(['/']);
  }
}