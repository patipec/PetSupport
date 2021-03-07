import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {PetsitterComponent} from './petsitter/petsitter.component';
import {PettsittersComponent} from './pettsiters.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {path: '', component: PettsittersComponent, pathMatch: 'full'},
      {path: ':id', component: PetsitterComponent},
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PetsittersRoutingModule {
}

