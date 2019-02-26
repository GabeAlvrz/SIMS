import { Component, OnInit, Output, Input, EventEmitter } from '@angular/core';
import * as Survey from 'survey-angular';
import * as widgets from 'surveyjs-widgets';

import 'inputmask/dist/inputmask/phone-codes/phone.js';

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
  selector: 'app-gradseniorsurveys',
  templateUrl: './gradseniorsurveys.component.html',
  styleUrls: ['./gradseniorsurveys.component.css']
})
export class GradseniorsurveysComponent implements OnInit {
  @Output() submitSurvey = new EventEmitter<any>();

  @Input()
  json: object;

  surveyJson: any = {
    pages: [
      {
        name: 'gradseniorsurvey',
        elements: [
          {
            name: 'info',
            title: 'General Information',
            type: 'multipletext',
            colCount: 2,
            isRequired: true,
            items: [
              {
                name: 'semester',
                title: 'Semester:',
                placeHolder: 'Fall 19 / Spring 19 / Summer 19',
              },
              {
                name: 'program',
                title: 'Program:',
                placeHolder: 'BA / BS',
              }
            ]
          },
          {
            name: 'objective1',
            title: 'Objective 1: To provide students with a solid foundation in Computer Science,' +
                   'Mathematics, and Basic Sciences, which will allow them to successfully pursue ' +
                   'graduate studies in Computer Science, or other related degrees.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'objective2',
            title: 'Objective 2: To provide students with a solid foundation in Computer Science,' +
                   'Mathematics, and Basic Sciences, which will allow them to successfully compete ' +
                   'for quality jobs in all functions of Computer Science employment, ranging from ' +
                   'software developer to customer support.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'objective3',
            title: 'Objective 3: To equip students with life-long learning skills, which will allow ' +
                   'them to successfully adapt to the evolving technologies throughout their ' +
                   'professional careers.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'objective4',
            title: 'Objective 4: To equip students with communication skills, which will allow ' +
                   'them to collaborate efficiently with other members of a team for the development ' +
                   'of large computer and software systems.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'objective5',
            title: 'Objective 5: To provide students with broad education neccesary to understand the ' +
                   'impact of computer technology in a global and societal context.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'outcome1',
            title: 'Outcome 1: Ability to effectively apply knowledge of computing and mathematics ' +
                   'to computer science problem.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'outcome2',
            title: 'Outcome 2: Ability to apply mathematical foundations, algorithmic principles, and ' +
                   'computer science theory in the modelingand design of computer-based systems in a way' +
                   'that demonstrates comprehension of the trade=offs involved in design choices',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'outcome3',
            title: 'Outcome 3: Ability to design, implement and evaluate computer-based components, ' +
                   'systems, processes or programs to meet desired needs and specifications.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'outcome4',
            title: 'Outcome 4: Ability to apply, design, and develop principles in the construction of ' +
                   'software systems of varying complexity.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'outcome5',
            title: 'Outcome 5: Ability tand skills to effectively use state-of-the-art techniques and computing ' +
                   'tools for analysis, design, and implementation of computing systems.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'outcome6',
            title: 'Outcome 6: Ability to function effectively as a member of a team assembled to undertake ' +
                   'a common goal.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'outcome7',
            title: 'Outcome 7: An understanding of professional, ethical, legal, security, and ' +
                   'social issues and responsibilities.',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'outcome8',
            title: 'Outcome 8: Ability to communicate effectively to both technical and non-technical audiences. ',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'outcome9',
            title: 'Outcome 9: Ability to analyze the local and global impact of computing on individuals ' +
            ', organizations and society. ',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
          {
            name: 'outcome10',
            title: 'Outcome 10: Recognition of the need for and the ability to engage in life-long' +
            'learning. The ability to successfully pursue professional development ',
            type: 'radiogroup',
            colCount: 4,
            choices: ['Exceeds Expectation', 'Meet Expectations', 'Marginally Acceptable', 'Unacceptable'],
            isRequired: true
          },
        ]
      }
    ]
  };
  constructor() { }

  ngOnInit() {
    const surveyModel = new Survey.Model(this.surveyJson);
    surveyModel.onComplete.add(this.sendDataToServer);
    surveyModel.showQuestionNumbers = 'off';
    Survey.StylesManager.applyTheme('bootstrap');
    Survey.defaultBootstrapCss.navigationButton = 'btn btn-primary';
    Survey.SurveyNG.render('surveyElement', { model: surveyModel });
  }

  sendDataToServer(surveyModel) {
    console.log(JSON.stringify(surveyModel.data));
  }

}

