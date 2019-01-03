import { UserContact } from './UserContact';
import { UserRecord } from './UserRecord';
import { UserCart } from './UserCart';
import { UserCartRecord } from './UserCartRecord';
import { UserChatRecord } from './UserChatRecord';

export interface User {
    userID: number;
    firstName: string;
    lastName: string;
    birthDate: Date | string;
    nationalNumber: string;

    userContacts: UserContact[];
    userSearchs: UserRecord[];
    userCarts: UserCart[];
    userCartRecords: UserCartRecord[];
    userChatRecords: UserChatRecord[];
}
