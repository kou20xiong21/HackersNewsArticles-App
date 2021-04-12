import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { NewsArticles } from '../model/NewsArticles';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit {
  public articles: NewsArticles[];
  private articlesToSearch: NewsArticles[];
  public isLoading: boolean;
  public startPage: number;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit() {
    this.getArticles();
  }

  getArticles() {
    this.isLoading = true;
    this.startPage = 1;

    this.http.get<NewsArticles[]>(this.baseUrl + 'articles/').pipe(
      map((response: NewsArticles[]) =>
        response.filter(article => article && article.url))).subscribe(response => {
          this.articles = response;
          this.articlesToSearch = response;
          this.isLoading = false;
        },
          error => console.log(error));
  }

  onSearch(searchString) {
    this.articles = this.articlesToSearch;

    if (searchString) {
      this.articles = this.articles.filter(article => article.title.toLocaleLowerCase().includes(searchString.toLowerCase()));
    }
  }
}
