import { User } from './User';
import { Contact } from './Contact';

export interface UserContact {
    userContactID: number;
    user: User;
    contact: Contact;
}
