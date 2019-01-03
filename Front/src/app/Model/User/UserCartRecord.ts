import { User } from './User';
import { CartRecord } from './CartRecord';

export interface UserCartRecord {
    userCartRecordID: number;
    user: User;
    cartRecord: CartRecord;
}
