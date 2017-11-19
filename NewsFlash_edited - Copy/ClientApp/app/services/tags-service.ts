import { Injectable } from "@angular/core";
import { Observable } from "rxjs/Observable";
import 'rxjs/add/observable/of';
import { ITagsService } from "./itags-service";

@Injectable()
export class TagsService implements ITagsService {
  getTagsAsync(): Observable<any[]> {
    throw new Error("Method not implemented.");
  }
  getTagsById(id: number): Observable<any> {
    throw new Error("Method not implemented.");
  }
  getTags(): any[] {
    throw new Error("Method not implemented.");
  }
  addTags(tag: any): void {
    throw new Error("Method not implemented.");
  }
  updateTags(tag: any): void {
    throw new Error("Method not implemented.");
  }
  
}
