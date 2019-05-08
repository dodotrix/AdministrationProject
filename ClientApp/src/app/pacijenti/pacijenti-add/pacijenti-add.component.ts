import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { PacijentService } from '../pacijent.service';


@Component({
  selector: 'app-pacijenti-add',
  templateUrl: './pacijenti-add.component.html',
  styleUrls: ['./pacijenti-add.component.css']
})
export class PacijentiAddComponent implements OnInit {

  constructor(private api: PacijentService, private route: ActivatedRoute, private formBuilder: FormBuilder) { }

  pacijentForm: FormGroup;
  showMsg: boolean = false;

  ngOnInit() {
    this.pacijentForm = this.formBuilder.group({
      ime : ['', Validators.required],
      prezime : ['', Validators.required],
      datumRodjenja : ['', Validators.required],
      telefon : ['', Validators.required],
      adresa : ['', Validators.required]
    })
  }

  onFormSubmit() {
    if(this.pacijentForm.valid){
      this.api.addPacijent(this.pacijentForm.value).subscribe(res => {
        this.showMsg = true;
        this.pacijentForm.reset();
      }, (err) => {
        console.log(err);
      });
    }
  }




}
