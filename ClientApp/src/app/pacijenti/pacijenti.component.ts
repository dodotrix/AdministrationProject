import { Component, OnInit } from '@angular/core';
import { IPacijent } from './pacijent';
import { PacijentService } from './pacijent.service';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-pacijenti',
  templateUrl: './pacijenti.component.html',
  styleUrls: ['./pacijenti.component.css']
})
export class PacijentiComponent implements OnInit {

  pacijenti: IPacijent[] = []; 


  constructor(private pacijentService: PacijentService) { }

  public getPacijenti(): void {
    this.pacijentService.getPacijenti().subscribe(res => {
      this.pacijenti = res;
    });
  }

  ngOnInit() {
    this.getPacijenti();
  }

}
