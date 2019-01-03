import { Nation } from './Nation';
import { Brand } from './Brand';
import { ProductScore } from './ProductScore';
import { ProductComment } from './ProductComment';
import { ProductMultiMedia } from './ProductMultiMedia';
import { ProductSeller } from './ProductSeller';
import { ProductSimilar } from './ProductSimilar';

export interface Product {
    productID: number;
    name: string;
    enabled: boolean;
    nation: Nation;
    brand: Brand;
    productScore: ProductScore[];
    productComment: ProductComment[];
    productMultiMedia: ProductMultiMedia[];
    productSeller: ProductSeller[];
    productSimilar: ProductSimilar[];
}
