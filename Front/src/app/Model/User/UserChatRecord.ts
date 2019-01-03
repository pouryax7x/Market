import { User } from './User';
import { ChatRecord } from './ChatRecord';

export interface UserChatRecord {
    userChatRecordID: number;
    user: User;
    chatRecord: ChatRecord;
}
