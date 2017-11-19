import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from "./components/home/home.component";
import { EditArticleComponent } from "./components/editarticle/editArticle.component";
import { NewarticleComponent } from "./components/newarticle/newArticle.component";
import { PreviewArticleComponent } from "./components/previewArticle/previewArticle.component";
import { ModuleWithProviders } from "@angular/core";
import { TagNameComponent } from "./components/tagname/tagname.component";

export const router: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'edit/:id', component: EditArticleComponent },
    { path: 'new', component: NewarticleComponent },
    { path: 'preview/:id', component: PreviewArticleComponent },
    { path: 'tagname', component: TagNameComponent },
    { path: '**', redirectTo: 'home' }

];

export const routes: ModuleWithProviders = RouterModule.forRoot(router);
