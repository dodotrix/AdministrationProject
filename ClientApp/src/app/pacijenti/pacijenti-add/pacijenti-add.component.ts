import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormControl, FormGroupDirective, FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { PacijentService } from '../pacijent.service';
import { IPacijent } from '../pacijent';


@Component({
  selector: 'app-pacijenti-add',
  templateUrl: './pacijenti-add.component.html',
  styleUrls: ['./pacijenti-add.component.css']
})
export class PacijentiAddComponent implements OnInit {

  constructor(private route: ActivatedRoute, private api: PacijentService, private formBuilder: FormBuilder) { }

  pacijentForm: FormGroup;
  pacijentIme: string = '';
  pacijentPrezime: string = '';
  pacijentDatum: Date = null;
  pacijentTelefon: string = '';
  pacijentAdresa: string = '';

  ngOnInit() {
    this.pacijentForm = this.formBuilder.group({
      'pacijentIme' : [null, Validators.required],
      'pacijentPrezime' : [null, Validators.required],
      'pacijentDatum' : [null, Validators.required],
      'pacijentTelefon' : [null, Validators.required],
      'pacijentAdresa' : [null, Validators.required]
    })
  }

  onFormSubmit(form:NgForm) {
    this.api.addPacijent(form).subscribe(res => {

    }, (err) => {
      console.log(err);
    });
  }




}
