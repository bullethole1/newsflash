import { Component, Inject, OnInit } from "@angular/core";
import { IArticlesService } from "../../services/iarticles-service";
import { ActivatedRoute } from "@angular/router";
import { ITagsService } from "../../services/itags-service";

@Component({
    selector: 'tagname',
    templateUrl: './tagname.component.html'
})
export class TagNameComponent implements OnInit {

  constructor( @Inject('ITagsServiceInterface') private iTagsService: ITagsService) {}

    tag: any = [{

    }];

    ngOnInit() {
      this.iTagsService.getTagsAsync().subscribe(tag => this.tag = tag);
    }

}
