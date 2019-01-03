import { User } from './User';
import {Record} from './Record';

export interface UserRecord {
    userRecordID: number;
    user: User;
    record: Record;
}
