import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { WineService } from '../../services/wine.service';
import { Wine } from '../../models/wine';

@Component({
  selector: 'app-create',
  standalone: false,
  templateUrl: './create.component.html',
  styleUrl: './create.component.sass'
})
export class CreateComponent implements OnInit{
  form!:FormGroup ;
constructor(
    private fb: FormBuilder,
    private wineService: WineService,
    private router: Router
  ) {}
  
  ngOnInit(): void {
    this.form=this.fb.group({
      name:[ '',Validators.required],
      type: ['', Validators.required],
      price: [0, Validators.required],
      year: [2024, Validators.required],
    })
  }
 

  

  submit() {
  const wine = this.form.value as Wine;
  this.wineService.create(wine).subscribe(() => {
    this.router.navigate(['/list']);
  });
}
}
