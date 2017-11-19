//import { Injectable } from "@angular/core";
//import { Observable } from "rxjs/Observable";
//import { ARTICLE_ITEMS } from "../Article.Data";
//import 'rxjs/add/observable/of';
//import { IArticlesService } from "./iarticles-service";
//import { Article } from "../../../models/Article";


//@Injectable()
//export class ArticlesService implements IArticlesService {
//  getArticleWithTagsById(id: number): Observable<Article> {
//    throw new Error("Method not implemented.");
//  }
//    updateArticle(article: Article): Observable<Article> {
//        throw new Error("Method not implemented.");
//    }
//    getArticleById(id: number): Observable<Article> {
//        throw new Error("Method not implemented.");
//    }

//    private articleItems = ARTICLE_ITEMS;

//    getArticles(): Article[] {
//        return this.articleItems;
//    }

//    getArticlesAsync(): Observable<Article[]> {
//        return Observable.of(this.articleItems);
//    }

//    addArticle(article: Article) {
//        this.articleItems.push(article);
//        console.log(this.articleItems);
//    }

//    //updateArticle(article: Article {
//    //    let index = findIndex(this.articleItems, (a: Article) => {
//    //        return a.id === article.id;
//    //    });
//    //    this.articleItems[index] = article;
//    //    console.log(this.articleItems);
//    //}
//}
