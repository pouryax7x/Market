import { Product } from './Product';
import { Similar } from './Silmilar';

export interface ProductSimilar {
    productSimilarID: number;
    product: Product;
    similar: Similar;
}
