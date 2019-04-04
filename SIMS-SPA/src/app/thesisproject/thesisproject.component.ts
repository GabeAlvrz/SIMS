import { Component, OnInit, EventEmitter } from '@angular/core';
import { FileUploader } from 'ng2-file-upload';
import { environment } from 'src/environments/environment';
import { AlertifyService } from '../_services/alertify.service';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '../_services/auth.service';
import { UploadingFileError } from 'survey-angular';
import { AgGridModule } from 'ag-grid-angular';

AgGridModule.withComponents(null);

@Component({
  selector: 'app-thesisproject',
  templateUrl: './thesisproject.component.html',
  styleUrls: ['./thesisproject.component.css']
})
export class ThesisprojectComponent implements OnInit {

  thesisProj = {'row': '', 'studentName': '', 'docType': '', 'topic': '', 'fileName': '', 'url': '', 'full_url': ''};
  rowClicked = {'row': '', 'studentName': '', 'docType': '', 'topic': '', 'fileName': '', 'url': ''};
  students   = [{'UserName': ''}];
  docTypes   = ['Thesis', ' Project'];
  uploader: FileUploader;
  hasBaseDropZoneOver = false;
  baseUrl    = environment.apiUrl;
  columnDefs = [
    {headerName: '#', field: 'row', resizable: true, width: 50},
    {headerName: 'Student Name', field: 'studentName', resizable: true, width: 200},
    {headerName: 'Thesis/Project', field: 'docType', resizable: true, width: 160},
    {headerName: 'Topic', field: 'topic', resizable: true, width: 80},
    {headerName: 'File', field: 'fileName', resizable: true, width: 160},
    {headerName: '', field: 'url', resizable: true, width: 0},
  ];

  rowData = [];
  rawRow  = [];

  grid_params = {
    columnGroups: true,
    allColumns: true,
    fileName: 'courses_offer.csv',
    columnSeparator: ','
  };
  gridApi;

  constructor(private authService: AuthService,
    private http: HttpClient, private alertify: AlertifyService) { }

  ngOnInit() {
    this.initializeUploader();
    this.GetThesisProjects();
    this.GetStudents();
  }

  fileOverBase(e: any): void {
    this.hasBaseDropZoneOver = e;
  }

  initializeUploader() {
    this.uploader = new FileUploader({
      authToken: 'Bearer ' + localStorage.getItem('token'),
      isHTML5: true,
      removeAfterUpload: true,
      autoUpload: false,
      maxFileSize: 10 * 1024 * 1024
    });

    this.uploader.onAfterAddingFile = (file) => {
      file.withCredentials = false;
      this.thesisProj.full_url = '';
    };

    this.uploader.onSuccessItem = (item, response, status, headers) => {
      if (response) {
        console.log(response);
        this.alertify.message(response);
        this.GetThesisProjects();
      }
    };
  }

  UpdateThesisProj() {
    const fNames = this.thesisProj.fileName.split('\\');
    const hLen = (fNames.length - 1);
    console.log(this.thesisProj);
    this.thesisProj.full_url = '' ;

    this.uploader.setOptions( {url: this.baseUrl +
      'ThesisProjects/UploadFile/' +
      this.thesisProj.studentName + '/' +
      fNames[hLen] + '/' +
      this.thesisProj.docType + '/' +
      this.thesisProj.topic});
    console.log(this.uploader.options.url);
    this.uploader.uploadAll();
  }

  ExportGridData2Csv() {
    this.gridApi.exportDataAsCsv(this.grid_params);
  }

  onGridReady(params) {
    this.gridApi = params.api;
  }
  onGridClicked(params) {
    if (params.data === []) { return; }
    this.rowClicked = params.data;
    this.thesisProj.studentName = this.rowClicked.studentName;
    this.thesisProj.docType     = this.rowClicked.docType;
    this.thesisProj.topic       = this.rowClicked.topic;
    this.thesisProj.url         = this.rowClicked.url;
    this.thesisProj.full_url    = this.baseUrl.substr(0, (this.baseUrl.length - 4)) + this.thesisProj.url;
  }

  GetThesisProjects() {
    this.http.get(this.baseUrl + 'ThesisProjects/GetThesisProjects').subscribe(
      (res: any) => {
        this.rowData = res;
        for (let i = 0; i < this.rowData.length; i++) {
          this.rowData[i]['row'] = (i + 1);
        }
      }, error => {
        this.alertify.error('GetThesisProjects()' + error);
      }
    );
  }

  GetStudents() {
    this.http.get(this.baseUrl + 'ThesisProjects/GetStudents').subscribe(
      (res: any) => {
        this.students = res;
        console.log(this.students);
      }, error => {
        this.alertify.error('GetStudents()' + error);
      }
    );
  }

}
