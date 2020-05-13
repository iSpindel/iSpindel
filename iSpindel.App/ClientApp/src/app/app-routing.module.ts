import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GraphComponent } from 'src/app/graph/graph.component';
import { LiveDataComponent } from './live-data/live-data.component';
import { NewMeasureComponent } from './new-measure/new-measure.component';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';

const routes: Routes = [
    { path: '', component: LiveDataComponent },
    { path: 'newMeasure', component: NewMeasureComponent },
    { path: 'viewMeasure', component: GraphComponent, canActivate: [AuthorizeGuard] },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
