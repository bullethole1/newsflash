import { Component, OnInit, Inject } from "@angular/core";
import { IArticlesService } from "../../services/iarticles-service";
import { ActivatedRoute } from "@angular/router";

@Component({
    selector: 'preview',
    templateUrl: './previewarticle.component.html',
})
export class PreviewArticleComponent implements OnInit {

    constructor( @Inject('IArticleServiceInterface') private iArticlesService: IArticlesService, private route: ActivatedRoute) { }

    article: any = [{

    }];

    ngOnInit() {

        this.iArticlesService
            .getArticleById(this.route.snapshot.params['id'])
            .subscribe(article => this.article = article);
    }

}
