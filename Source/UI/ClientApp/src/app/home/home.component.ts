import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

import { Order } from '../models/order'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
//export class HomeComponent {
//  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
//    http.post<Order>(baseUrl + 'order').subscribe(result => {
//      this.orders = result;
//    }, error => console.error(error));
//  }
//}
export class HomeComponent {
  public orderForm: FormGroup;
  private baseUrl: string;

  constructor(private formBuilder: FormBuilder, private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.orderForm = this.formBuilder.group({
      treeName: [],
      treeType: [],
      address: []
    });
    this.baseUrl = baseUrl;
  }

  //ngOnInit(): void {
  //  this.init();
  //}

  public saveOrder(): void {
    console.log(this.orderForm.value);

    this.http.post<Order>(this.baseUrl + 'order', this.orderForm.value).subscribe(result => {
      console.log(result);
    }, error => console.error(error));

    //this.http.post(this.basePath, book)

    //this.service.addBook(this.orderForm.value).subscribe((result) => {
    //  alert(`New book added with id = ${result}`)
    //});
  }

}
