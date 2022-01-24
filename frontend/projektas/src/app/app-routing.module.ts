import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './komponentai/login/login.component';
import { MainComponent } from './komponentai/main/main.component';
import { RegisterComponent } from './komponentai/register/register.component';

const routes: Routes = [
  {path: "login", component: LoginComponent },
  {path: "register", component: RegisterComponent },
  {path: "main", component: MainComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
