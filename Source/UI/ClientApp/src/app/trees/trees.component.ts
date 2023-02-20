import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Tree } from '../models/tree'

@Component({
  selector: 'app-trees',
  templateUrl: './trees.component.html'
})
export class TreesComponent {
  public trees: Tree[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Tree[]>(baseUrl + 'tree').subscribe(result => {
      this.trees = result;
    }, error => console.error(error));
  }
}
