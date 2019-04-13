import { Component, OnInit } from '@angular/core';
import { Pacijent } from '../shared/models/Pacijent';

@Component({
  selector: 'app-pacijenti',
  templateUrl: './pacijenti.component.html',
  styleUrls: ['./pacijenti.component.css']
})
export class PacijentiComponent implements OnInit {

  pacijent: Pacijent = {
    id: 1,
    ime: 'Dominik',
    prezime: 'Blazic',
    datumRodjenja: '29.01.1995',
    telefon: '01234567',
    adresa: 'Humboldtova 16',
    punoIme: 'Dominik Blazic'
  }


  constructor() { }

  ngOnInit() {
  }

}
