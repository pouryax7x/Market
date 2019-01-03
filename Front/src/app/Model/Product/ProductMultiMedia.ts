import { Product } from './Product';
import { MultiMedia } from './MultiMedia';

export interface ProductMultiMedia {
    productMultiMediaID: number;
    product: Product;
    multiMedia: MultiMedia;
}
