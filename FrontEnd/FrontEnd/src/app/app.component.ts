import { Component, OnInit } from '@angular/core';
import { Wine } from './models/wine';
import { WineService } from './services/wine.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: false,
  styleUrl: './app.component.sass'
})
export class AppComponent implements OnInit {

  wines:Wine[]=[];
  constructor(private wineService: WineService)
  {

  }
  
   ngOnInit() {
    this.wineService.getAll().subscribe(data => {
      this.wines = data;
    });
  }
}
