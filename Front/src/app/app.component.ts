import { Component, OnInit } from '@angular/core';
import { ProductService } from './Services/product.service';
import { Product } from './Model/Product/Product';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'ff';
  constructor(private _productService: ProductService) {
  }
  _product: Product[];
  GetProducts() {
    this._productService.getPerson().subscribe(x => this._product = x);
  }

  ngOnInit() {
this.GetProducts();
  }
}
