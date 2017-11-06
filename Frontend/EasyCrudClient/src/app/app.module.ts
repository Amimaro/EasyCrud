import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { PageNotFoundComponent } from './pages/not-found/not-found.component';
import { ProgrammerService } from './services/programmer.service';
import { FormBankComponent } from './pages/form-bank/form-bank.component';
import { FormKnoledgeComponent } from './pages/form-knoledge/form-knoledge.component';
import { FormEmailComponent } from './pages/form-email/form-email.component';
import { FormOccupationComponent } from './pages/form-occupation/form-occupation.component';
import { DeleteComponent } from './pages/delete/delete.component';

const appRoutes: Routes = [
  {
    path: 'programmer/home',
    component: HomeComponent,
    data: { title: 'Home' }
  },
  {
    path: 'programmer/form1',
    component: FormEmailComponent,
    data: { title: 'Cadastro - Easy CRUD - Parte 1' }
  },
  {
    path: 'programmer/form2',
    component: FormOccupationComponent,
    data: { title: 'Cadastro - Easy CRUD - Parte 2' }
  },
  {
    path: 'programmer/form3',
    component: FormBankComponent,
    data: { title: 'Cadastro - Easy CRUD - Parte 3' }
  },
  {
    path: 'programmer/form4',
    component: FormKnoledgeComponent,
    data: { title: 'Cadastro - Easy CRUD - Parte 4' }
  },
  {
    path: 'programmer/delete',
    component: DeleteComponent,
    data: { title: 'Cadastro - Easy CRUD' }
  },
  {
    path: '',
    redirectTo: '/programmer/home',
    pathMatch: 'full'
  },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PageNotFoundComponent,
    FormBankComponent,
    FormKnoledgeComponent,
    FormEmailComponent,
    FormOccupationComponent,
    DeleteComponent,
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    )
  ],
  providers: [ProgrammerService],
  bootstrap: [AppComponent]
})
export class AppModule { }
