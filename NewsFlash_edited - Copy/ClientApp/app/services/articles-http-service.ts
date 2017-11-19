import { Injectable } from "@angular/core";
import { IArticlesService } from "./iarticles-service";
import { Article } from "../../../models/Article";
import { Http, Response } from "@angular/http";
import { Observable } from "rxjs/Observable";
import 'rxjs/add/operator/map'


@Injectable()
export class ArticlesHttpService implements IArticlesService {

  public constructor(private http: Http) { }

  getArticleWithTagsById(id: number): Observable<Article> {
    return this.getArticlesAsync().map(article => article.find(article => article.id == id));
  }

  getArticles(): Article[] {
    throw new Error("Method not implemented.");
  }

  getArticlesAsync(): Observable<Article[]> {
    return this.http.get('/api/articles')
      .map((res: Response) => res.json());
  }

  getArticleById(id: number): Observable<Article> {
    return this.getArticlesAsync()
      .map(article => article.find(article => article.id == id));
  }


  addArticle(article: Article) {
    this.http.post('/api/articles', article)
      .subscribe();
  }

  updateArticle(article: Article) {

    this.http.put('/api/articles/', article).subscribe();

  }
}
