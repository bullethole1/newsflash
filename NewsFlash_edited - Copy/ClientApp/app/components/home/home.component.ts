import { Component, Inject, OnInit } from '@angular/core';
import { IArticlesService } from "../../services/iarticles-service";
import { Router, NavigationEnd } from "@angular/router";

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit{
    constructor( @Inject('IArticleServiceInterface') private iArticlesService: IArticlesService, private route: Router) { }

    articles: {} = [{
    }];
    ngOnInit() {

        this.iArticlesService.getArticlesAsync().subscribe(articles => this.articles = articles);
    };
}
