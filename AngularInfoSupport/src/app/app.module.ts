import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CommonModule } from '@angular/common';
import {CursusService} from './shared/cursus/cursus.service'
import { UploadService } from './shared/upload/upload.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Routes } from '@angular/router';
import { CursusComponent } from './shared/cursus/cursus.component';
import { UploadComponent } from './shared/upload/upload.component';

const appRoutes: Routes = [
  { path: '', component: CursusComponent },
  { path: '', component: UploadComponent },
]

@NgModule({
  declarations: [
    AppComponent,
    CursusComponent,
    UploadComponent

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [CursusService, UploadService],
  bootstrap: [AppComponent]
})
export class AppModule { }
