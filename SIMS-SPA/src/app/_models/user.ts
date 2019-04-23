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
    mastersCommMember1: string;
    mastersCommMember2: string;
    mastersCommMember3: string;
    mastersCommMember4: string;
    mastersCommMember5: string;
    mastersCommFormDate: Date;
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
    doctorateCommMember1: string;
    doctorateCommMember2: string;
    doctorateCommMember3: string;
    doctorateCommMember4: string;
    doctorateCommMember5: string;
    doctorateCommMember6: string;
    doctorateCommFormDate: Date;
    dissertationDefenseDate: Date;
    dissertationTitle: string;
    doctorateGradDate: Date;
    // faculty info
    office: string;
    researchInterest: string;
    degree: string;
    designation: string;
    current: string;
    title: string;

    photoUrl: string;
    photos?: Photo[];
    roles?: string[];
}
