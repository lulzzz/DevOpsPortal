import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ftp-files',
  templateUrl: './ftp-files.component.html',
  styleUrls: ['./ftp-files.component.css']
})
export class FtpFilesComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}

interface FtpFileResult {
  errored: boolean;
  district: string;
  path: string;
  timeLimit: number;
  lastDropTime: string;
  timeChecked: string;
}
