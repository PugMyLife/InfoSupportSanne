import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CommonModule } from '@angular/common';
import {CursusService} from './shared/cursus/cursus.service'
import { UploadService } from './shared/upload/upload.service';
import { FormsModule } from '@angular/forms';
import { Routes } from '@angular/router';
import { CursusComponent } from './shared/cursus/cursus.component';

const appRoutes: Routes = [
  { path: '', component: CursusComponent },
]

@NgModule({
  declarations: [
    AppComponent,
    CursusComponent

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    CommonModule,
    FormsModule,
  ],
  providers: [CursusService, UploadService],
  bootstrap: [AppComponent]
})
export class AppModule { }
