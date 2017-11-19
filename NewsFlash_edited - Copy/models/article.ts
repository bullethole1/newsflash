  export class Article {
  public id: number;
  public header: string;
  public img: string;
  public summary: string;
  public body: string;
  public link: string;
  public source: string;
  public publishDate: Date;
  public tags: string[];

  constructor(id: number, header: string, img: string, summary: string, body: string, link: string, source: string, publishDate: Date, tags: string[])
  {
    this.id = id;
    this.header = header;
    this.img = img;
    this.summary = summary;
    this.body = body;
    this.link = link;
    this.source = source;
    this.publishDate = publishDate;
    this.tags = tags;
  }

}
