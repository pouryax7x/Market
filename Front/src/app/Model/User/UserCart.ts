import { User } from './User';
import { Cart } from './Cart';

export interface UserCart {
    userCartID: number;
    user: User;
    cart: Cart;
}
