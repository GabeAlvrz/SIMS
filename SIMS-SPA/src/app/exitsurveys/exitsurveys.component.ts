import { Component, OnInit, Output, Input, EventEmitter } from '@angular/core';
import * as Survey from 'survey-angular';
import * as widgets from 'surveyjs-widgets';

import 'inputmask/dist/inputmask/phone-codes/phone.js';
import { environment } from 'src/environments/environment';
import { AlertifyService } from '../_services/alertify.service';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '../_services/auth.service';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { UserService } from '../_services/user.service';
import {Injector} from '@angular/core';

export let InjectorInstance: Injector;


widgets.icheck(Survey);
widgets.select2(Survey);
widgets.inputmask(Survey);
widgets.jquerybarrating(Survey);
widgets.jqueryuidatepicker(Survey);
widgets.nouislider(Survey);
widgets.select2tagbox(Survey);
widgets.signaturepad(Survey);
widgets.sortablejs(Survey);
widgets.ckeditor(Survey);
widgets.autocomplete(Survey);
widgets.bootstrapslider(Survey);
widgets.prettycheckbox(Survey);

Survey.Survey.cssType = 'bootstrap';
Survey.JsonObject.metaData.addProperty('questionbase', 'popupdescription:text');
Survey.JsonObject.metaData.addProperty('page', 'popupdescription:text');

@Component({
  selector: 'app-exitsurveys',
  templateUrl: './exitsurveys.component.html',
  styleUrls: ['./exitsurveys.component.css']
})
export class ExitsurveysComponent implements OnInit {
  @Output() submitSurvey = new EventEmitter<any>();

  @Input()
  json: object;

  surveyJson: any = {
    pages: [
      {
        name: 'exitsurvey',
        elements: [
          {
            name: 'surveyDate',
            title: 'Date',
            type: 'text',
            inputType: 'date',
            isRequired: true,
          },
          {
            name: 'studentName',
            title: 'Name',
            type: 'text',
            isRequired: true
          },
          {
            name: 'ssId',
            title: 'Student ID',
            type: 'text',
            validators: [
              {
                type: 'numeric',
                minValue: 850000000,
                maxValue: 859999999
              }
            ]
          },
          {
            name: 'degreeProgram',
            title: 'Select one of your Computer Science degree program',
            type: 'radiogroup',
            colCount: 4,
            choices: ['B.A.', 'B.S.', 'M.S.', 'Ph.D.'],
            // isRequired: true
          },
          {
            type: 'dropdown',
            title: 'Term of Expected Graduation',
            name: 'termGraduateSemester',
            choices: [
              'Spring',
              'Summer',
              'Fall'
            ],
          },
          {
            name: 'termGraduateYear',
            title: 'Year',
            type: 'text',
            // isRequired: true
          },
          {
            name: 'Personal Contact Information',
            type: 'multipletext',
            colCount: 2,
            isRequired: true,
            items: [
              {
                name: 'contact1Name',
                title: 'Name'
              },
              {
                name: 'contact1Address',
                title: 'Address'
              },
              {
                name: 'contact1PhoneHome',
                title: 'Home Phone'
              },
              {
                name: 'contact1PhoneWork',
                title: 'Work Phone'
              },
              {
                name: 'contact1PhoneCell',
                title: 'Cell Phone'
              },
              {
                name: 'contact1Email',
                title: 'Email',
                validators: [
                  {
                      type: 'email'
                  }
                ]
              },
            ]
          },
          {
            type: 'radiogroup',
            name: 'contactOtherOption',
            title: 'Please select:',
            titleLocation: 'left',
            choices: [
              'Parent',
              'Sibling',
              'Other Relative',
              'Friend'
            ],
            colCount: 4
          },
          {
            name: 'Other Contact Information',
            type: 'multipletext',
            colCount: 2,
            // isRequired: true,
            items: [
              {
                name: 'contact2Name',
                title: 'Name'
              },
              {
                name: 'contact2Address',
                title: 'Address'
              },
              {
                name: 'contactPhoneHome',
                title: 'Home Phone'
              },
              {
                name: 'contact2PhoneWork',
                title: 'Work Phone'
              },
              {
                name: 'contactPhoneCell',
                title: 'Cell Phone'
              },
              {
                name: 'contact2Email',
                title: 'Email'
              },
            ]
          },
          {
            name: 'assessQ',
            // tslint:disable-next-line:max-line-length
            title: 'Please rate your expectations about the CS program (EX = Exceeds; MT = Meets; ' +
               'MA = Marginally Acceptable; UN = Unacceptable)',
            type: 'matrix',
            // isRequired: true,
            columns: [
              {
               value: 'Exceeds',
               text: 'EX'
              },
              {
               value: 'Meets',
               text: 'MT'
              },
              {
               value: 'Marginally Acceptable',
               text: 'MA'
              },
              {
               value: 'Unacceptable',
               text: 'UN'
              }
             ],
             rows: [
              {
               value: 'assessQ1',
               text: 'The advisment quality in the department'
              },
              {
               value: 'assessQ2',
               text: 'The program prepared me for my career'
              },
              {
               value: 'assessQ3',
               text: 'The quality of the education I have received in the department'
              }
            ]
          },
          {
            name: 'assessComment',
            title: 'Please write any recommendation you have to improve the CS program',
            type: 'comment'
          },
          {
            name: 'Graduate School',
            title: 'If you have decided to pursue a graduate or professional degree, please provide the following information:',
            type: 'multipletext',
            colCount: 2,
            // isRequired: true,
            items: [
              {
                name: 'furtherStudySchool',
                title: 'School'
              },
              {
                name: 'furtherStudyMajor',
                title: 'Major'
              },
              {
                name: 'furtherStudyScholarship',
                title: 'Scholarship/Assistantship'
              }
            ]
          },
          {
            name: 'job search',
            title: 'If you have started searching for employment, please provide the following information',
            type: 'multipletext',
            items: [
              {
                name: 'jobSearchDuration',
                title: 'Number of months searching:'
              },
              {
                name: 'jobSearchNumInterview',
                title: 'Number of interviews you had:'
              },
              {
                name: 'jobSearchNumOffer',
                title: 'Number of job offers obtained:'
              },
              {
                name: 'jobSearchAvgSalary',
                title: 'Average starting salary offered:'
              }
            ]
          },
          {
            name: 'accepted offer',
            title: 'If you have already accepted an offer, please provide the following information if possible',
            type: 'multipletext',
            items: [
              {
                name: 'jobCompany',
                title: 'Company:'
              },
              {
                name: 'jobCity',
                title: 'City:'
              },
              {
                name: 'jobTitle',
                title: 'Position/Title:'
              },
              {
                name: 'jobCompanyContact',
                title: 'Your Company contact information (if available):'
              },
              {
                name: 'jobCompanyWeb',
                title: 'Web address:'
              },
              {
                name: 'jobSalary',
                title: 'Starting salary:'
              }
            ]
          },
         {
          type: 'radiogroup',
          name: 'NetworkingQ1',
          title: 'May we refer students to you for questions regarding the CS field as career?',
          choices: [
            'YES',
            'NO'
          ],
          colCount: 2
        },
        {
          type: 'radiogroup',
          name: 'NetworkingQ2',
          title: 'Can students use you as a contact for possible job prospects?',
          choices: [
            'YES',
            'NO'
          ],
          colCount: 2
        },
        ]
      }]
  };
  baseUrl = environment.apiUrl;

  constructor(private userService: UserService, private authService: AuthService,
    private http: HttpClient, private injector: Injector,
    private route: ActivatedRoute, private alertify: AlertifyService) { InjectorInstance = this.injector;  }

  ngOnInit() {
    const surveyModel = new Survey.Model(this.surveyJson);
    surveyModel.onComplete.add(this.sendDataToServer);
    Survey.StylesManager.applyTheme('bootstrap');
    Survey.defaultBootstrapCss.navigationButton = 'btn btn-primary';
    Survey.SurveyNG.render('surveyElement', { model: surveyModel });
  }

  sendDataToServer(surveyModel) {
    const objSurvey = new ClassSurvey();
    objSurvey.sendData(surveyModel.data);
  }

}
export class ClassSurvey implements OnInit {
  baseUrl = environment.apiUrl;
  private http: HttpClient;
  constructor() {
    this.http = InjectorInstance.get<HttpClient>(HttpClient);
  }
  ngOnInit() {}

  sendData(surveyData) {
    console.log(surveyData);
    this.http.post( this.baseUrl + 'ExitSurveys', surveyData).subscribe(
      (res: any) => {
        console.log('Exit Survey Updated');
      }, error => {
        console.log('Exit Survey Update Error');
      }
    );
  }

}
