import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LiveDataComponent } from './live-data/live-data.component';
import { NewMeasureComponent } from './new-measure/new-measure.component';
import { ListMeasuresComponent } from './list-measures/list-measures.component';
import { BeerDetailsComponent } from './beer-details/beer-details.component';
import { CurrentMeasureComponent } from './current-measure/current-measure.component';
import { BrewCalculatorsComponent } from './brew-calculators/brew-calculators.component';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
