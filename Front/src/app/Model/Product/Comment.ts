import { User } from '../User/User';

export interface Comment {
    commentID: number;
    subject: string;
    user: User;
}
