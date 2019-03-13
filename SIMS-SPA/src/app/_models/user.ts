import { Photo } from './photo';

export interface User {
    id: number;
    userName: string;
    firstName: string;
    middleName?: string;
    lastName: string;
    level: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    country: string;
    interests?: string;
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];
    roles?: string;
}
