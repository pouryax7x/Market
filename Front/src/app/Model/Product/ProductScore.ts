import { Product } from './Product';
import { Score } from './Score';

export interface ProductScore {
    productScoreID: number;
    product: Product;
    score: Score;
}
