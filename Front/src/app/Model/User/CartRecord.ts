import { Product } from '../Product/Product';

export interface CartRecord {
    cartRecordID: number;
    product: Product;
    price: number;
    number: number;
    buyDate: Date | string;
}
