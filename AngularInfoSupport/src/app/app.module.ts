import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CursusDetailsComponent } from './cursus-details/cursus-details.component';
import { CursusDetailUploadComponent } from './cursus-details/cursus-detail-upload/cursus-detail-upload.component';

@NgModule({
  declarations: [
    AppComponent,
    CursusDetailsComponent,
    CursusDetailUploadComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
