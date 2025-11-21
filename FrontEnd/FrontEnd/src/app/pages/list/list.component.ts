import { Component, OnInit } from '@angular/core';
import { Wine } from '../../models/wine';
import { WineService } from '../../services/wine.service';

@Component({
  selector: 'app-list',
  standalone: false,
  templateUrl: './list.component.html',
  styleUrl: './list.component.sass'
})
export class ListComponent implements OnInit {

  wines: Wine[] = [];

  constructor(private wineService: WineService) {}

  ngOnInit() {
    this.load();
  }

  load() {
    this.wineService.getAll().subscribe(data => {
      this.wines = data;
    });
  }

  delete(id: string) {
    this.wineService.delete(id).subscribe(() => {
      this.load();
    });
  }
}
