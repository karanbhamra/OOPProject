import { Photo } from './photo';

export interface User {
    // replicate what we are returning for user
    id: number;
    username: string;
    alias: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    country: string;
    arrestedFor: string;
    interests?: string;
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];
}
