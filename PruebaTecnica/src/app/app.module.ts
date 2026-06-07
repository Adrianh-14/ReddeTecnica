import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import {RouterModule, Routes} from '@angular/router';

import { AppComponent } from './app.component';
import { EmpresaListaComponent } from './EmpresaLista/empresalista.component';
import { EmpresaCrearComponent } from './EmpresaCrear/empresacrear.component';
import { EmpresaVistaComponent } from './EmpresaVista/empresavista.component';
import { EmpresaEditarComponent } from './EmpresaEditar/empresaeditar.component';


const routes: Routes = [
  { path: '', component: EmpresaListaComponent },
  { path: 'crear', component: EmpresaCrearComponent },
  { path: 'ver/:id', component: EmpresaVistaComponent },
  { path: 'editar/:id', component: EmpresaEditarComponent }
];


@NgModule({
 declarations: [AppComponent, EmpresaListaComponent, EmpresaCrearComponent, EmpresaVistaComponent, EmpresaEditarComponent],

  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes),

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
