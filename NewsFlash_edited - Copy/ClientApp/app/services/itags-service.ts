import { Observable } from "rxjs/Observable";
import { Tag } from "../../../models/Tag";


export interface ITagsService {

  getTagsAsync(): Observable<Tag[]>;

  getTagsById(id: number): Observable<Tag>;

  getTags(): Tag[];

  addTags(tag: Tag): void;

  updateTags(tag: Tag): void;
}
