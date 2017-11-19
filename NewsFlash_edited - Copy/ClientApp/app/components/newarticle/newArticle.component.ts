import { Component, OnInit, Inject } from "@angular/core";
import { Article } from "../../../../models/Article";
import { IArticlesService } from "../../services/iarticles-service";
import { Router } from "@angular/router";
import { ITagsService } from "../../services/itags-service";

@Component({
  selector: 'new',
  templateUrl: './newarticle.component.html',
})
export class NewarticleComponent implements OnInit {
  article: Article;
  date: Date;



  constructor( @Inject('IArticleServiceInterface') private iArticleService: IArticlesService, @Inject('ITagsServiceInterface') private iTagsService: ITagsService, private route: Router)
  {
    this.article =
      new Article(-1, '', '', '', '', '', '', new Date(), []);   

  }

  ngOnInit() {
  }

  setDate(date: Date) {
    this.article.publishDate = new Date();
    console.log(date);

  }


  saveArticle(article: Article) {
    this.iArticleService.addArticle(article);
    this.route.navigate(['/home']);
    //this.iArticleService.getArticlesAsync().subscribe(article => this.article = article);
  }

  cancelArticle() {
    this.route.navigate(['/home']);
  }
}
