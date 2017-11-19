import { Component, Inject, OnInit } from '@angular/core';
import { IArticlesService } from "../../services/iarticles-service";
import { ActivatedRoute, Router, NavigationEnd } from "@angular/router";
import { Article } from "../../../../models/Article";
import { HomeComponent } from "../home/home.component";
import { ITagsService } from "../../services/itags-service";
import { Tag } from "../../../../models/Tag";

@Component({
  selector: 'edit',
  templateUrl: './editArticle.component.html'
})
export class EditArticleComponent {

  constructor( @Inject('IArticleServiceInterface') private iArticlesService: IArticlesService, @Inject('ITagsServiceInterface') private iTagsService: ITagsService, private route: Router, private activatedRoute: ActivatedRoute) { }
  article: any = [{

  }];

  tags: string[] = [];


  ngOnInit() {

    this.iArticlesService.getArticleWithTagsById(this.activatedRoute.snapshot.params['id'])
      .subscribe(article => this.article = article);
    //this.iArticlesService
    //  .getArticleById(this.activatedRoute.snapshot.params['id'])
    //  .subscribe(article => this.article = article);
  }

  updateArticle(article: Article) {
    this.iArticlesService.updateArticle(article);
    this.route.navigate(['/home']);
    this.iArticlesService.getArticlesAsync().subscribe(articles => this.article = articles);
  }

  cancelUpdate() {
    this.route.navigate(['/home']);
  }
}
