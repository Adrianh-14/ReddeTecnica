import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-empresa-formulario',
  templateUrl: './empresaformulario.component.html'
})
export class EmpresaFormComponent implements OnInit {

  empresa: any = { nombre: '', rnc: '', telefono: '', email: '' };
  esEdicion = false;
  readonly api = 'http://localhost:3000/EmpresasControllers';

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {}

  ngOnInit() {
    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.esEdicion = true;
      this.http.get(`${this.api}/Obtener/${id}`).subscribe(data => this.empresa = data);
    }
  }

  guardar() {
    const op = this.esEdicion
      ? this.http.put(`${this.api}/${this.empresa.id}`, this.empresa)
      : this.http.post(this.api, this.empresa);
    op.subscribe(() => this.router.navigate(['/']));
  }
}