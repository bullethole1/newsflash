import { Observable } from "rxjs/Observable";
import { Article } from "../../../models/Article";
import { Tag } from "../../../models/Tag";

export interface IArticlesService {

    getArticlesAsync(): Observable<Article[]>;

    getArticleById(id: number): Observable<Article>;

    getArticleWithTagsById(id: number): Observable<Article>;

    getArticles(): Article[];

    addArticle(article: Article): void;

    updateArticle(article: Article): void;

}
