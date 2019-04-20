import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { PacijentiComponent } from './pacijenti/pacijenti.component';
import { HttpClientModule } from '@angular/common/http';
import { PacijentDetailComponent } from './pacijenti/pacijent-detail/pacijent-detail.component';
import { PacijentiAddComponent } from './pacijenti/pacijenti-add/pacijenti-add.component';

const appRoutes: Routes = [
  { path: 'pacijenti', component: PacijentiComponent },
  { path: 'add', component: PacijentiAddComponent },
  { path: 'pacijent/:id', component: PacijentDetailComponent }

]

@NgModule({
  declarations: [
    AppComponent,
    PacijentiComponent,
    PacijentDetailComponent,
    PacijentiAddComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }


