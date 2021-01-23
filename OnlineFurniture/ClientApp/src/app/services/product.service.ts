import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Router} from '@angular/router';
import {environment} from '../../environments/environment';
import {Observable} from 'rxjs';
import {ProductModelServer, ServerResponse} from '../models/product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private SERVER_URL = environment.SERVER_URL;
  constructor(private http: HttpClient) { }

  /* This is to fetch all products from the backend server */
  getAllProducts(numberOfResults= 10): Observable<ServerResponse> {
    console.log('gg');
    return this.http.get<ServerResponse>(this.SERVER_URL + '/products', {
      params: {
        limit: numberOfResults.toString()
      }
    });
  }
  getProductsTest(): Array<ProductModelServer> {
    return [
      {
        id: 1,
        name: 'String',
        category: 'String',
        description: 'String',
        image: 'https://images-na.ssl-images-amazon.com/images/I/71VOUtLV5UL._AC_SL1500_.jpg',
        price: 20,
        quantity: 5,
        images: 'String',
      }
    ];
  }
  /* GET SINGLE PRODUCT FROM SERVER*/
  getSingleProduct(id: number): Observable<ProductModelServer> {
    return this.http.get<ProductModelServer>(this.SERVER_URL + '/products/' + id);
  }

  /*GET PRODUCTS FROM ONE CATEGORY */
  getProductsFromCategory(catName: string): Observable<ProductModelServer[]>  {
    return this.http.get<ProductModelServer[]>(this.SERVER_URL + '/products/category/' + catName);
  }
}