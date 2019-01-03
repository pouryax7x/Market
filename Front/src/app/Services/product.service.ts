import { Injectable } from '@angular/core';
import { Product } from '../Model/Product/Product';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private heroesUrl = 'https://127.0.0.1:5001/api/product';
  // URL to web api

  constructor(
    private http: HttpClient) { }

  getPerson(): Observable<Product[]> {
    const url = this.heroesUrl;
    return this.http.get<Product[]>(url);
  }
}
