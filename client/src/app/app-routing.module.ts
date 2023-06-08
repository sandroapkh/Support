import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MainComponent } from './home/main/main.component';
import { SentsComponent } from './home/sents/sents.component';
import { ArchiveComponent } from './home/archive/archive.component';
import { AddComponent } from './home/add/add.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'main', component: MainComponent },
  { path: 'sents', component: SentsComponent },
  { path: 'archive', component: ArchiveComponent },
  { path: 'add', component: AddComponent },
  { path: '**', component: HomeComponent, pathMatch: 'full' },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
