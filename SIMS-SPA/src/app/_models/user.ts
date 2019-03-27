import { Photo } from './photo';
import { Committee } from './committee';

export interface User {
    // gen info
    id: number;
    userName: string;
    firstName: string;
    middleName: string;
    lastName: string;
    fullName: string;
    dateOfBirth: Date;
    email: string;
    phoneNumber: string;
    phoneNumber2: string;
    street: string;
    city: string;
    state: string;
    country: string;
    currentAcademicLevel: string;
    degreeProgram: string;
    currentProgram: string;
    notes: string;
    // bachelors info
    bachelorsStartDate: Date;
    bachelorsMentor: string;
    bachelorsProjectAdvisor: string;
    bachelorsThesisAdvisor: string;
    bachelorsProjectTitle: string;
    bachelorsThesisTitle: string;
    bachelorsGradDate: Date;
    // masters info
    mastersStartDate: string;
    mastersFocus: string;
    mastersProjectAdvisor: string;
    mastersThesisAdvisor: string;
    mastersCommittee: Committee;
    mastersDefenseDate: Date;
    mastersProjectTitle: string;
    mastersThesisTitle: string;
    mastersGradDate: Date;
    // PhD info
    doctoralCandidate: string;
    doctorateStartDate: Date;
    dateAcceptedForCandidacy: Date;
    doctorateAdvisor: string;
    externalAdvisor: string;
    doctorateCommittee: Committee;
    dissertationDefenseDate: Date;
    dissertationTitle: string;
    doctorateGradDate: Date;
    photoUrl: string;
    photos?: Photo[];
    roles?: string[];
}
