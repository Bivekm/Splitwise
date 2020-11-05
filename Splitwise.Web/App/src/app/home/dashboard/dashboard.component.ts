import { Component, OnInit } from '@angular/core';
import { FriendDTO } from 'src/app/model/models';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  Friends: FriendDTO[];
  constructor() { }

  ngOnInit(): void {
  }

}
