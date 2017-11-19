import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { ArticlesService } from "./services/articles-service";
import { ArticlesHttpService } from "./services/articles-http-service";
import { EditArticleComponent } from "./components/editarticle/editArticle.component";
import { NewarticleComponent } from "./components/newarticle/newArticle.component";
import { PreviewArticleComponent } from "./components/previewArticle/previewArticle.component";
import { routes } from "./app.router";
import { TagNameComponent } from "./components/tagname/tagname.component";
import { TagsHttpService } from "./services/tags-http-service";
import { RlTagInputModule } from 'angular2-tag-input';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    EditArticleComponent,
    NewarticleComponent,
    PreviewArticleComponent,
    TagNameComponent
  ],
  imports: [
    CommonModule,
    HttpModule,
    FormsModule,
    RlTagInputModule,
    routes
  ],
  providers: [{ provide: 'IArticleServiceInterface', useClass: ArticlesHttpService }, { provide: 'ITagsServiceInterface', useClass: TagsHttpService },
  ],

})
export class AppModuleShared {
}
