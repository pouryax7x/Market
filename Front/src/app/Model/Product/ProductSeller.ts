import { Product } from './Product';
import { Seller } from './Seller';

export interface ProductSeller {
    productSellerID: number;
    product: Product;
    seller: Seller;
    number: number;
    price: number;
}
