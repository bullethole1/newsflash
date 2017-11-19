import { Injectable } from "@angular/core";
import { Http, Response } from "@angular/http";
import { Observable } from "rxjs/Observable";
import 'rxjs/add/operator/map'
import { ITagsService } from "./itags-service";
import { Tag } from "../../../models/Tag";

@Injectable()
export class TagsHttpService implements ITagsService {

  public constructor(private http: Http){}

  getTagsAsync(): Observable<Tag[]> {
    return this.http.get('/api/tags')
      .map((res: Response) => res.json());
  }
  getTagsById(id: number): Observable<Tag> {
    return this.getTagsAsync()
      .map(tags => tags.find(tag => tag.id == id));
  }
  getTags(): Tag[] {
    throw new Error("Method not implemented.");
  }
  addTags(tag: Tag): void {
    this.http.post('/api/tags', tag)
      .subscribe();
  }
  updateTags(tag: Tag): void {
    this.http.put('/api/tags/', tag).subscribe();
  }

}
