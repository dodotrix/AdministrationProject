import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PacijentService } from '../pacijent.service';
import { IPacijent } from '../pacijent';



@Component({
  selector: 'app-pacijent-detail',
  templateUrl: './pacijent-detail.component.html',
  styleUrls: ['./pacijent-detail.component.css']
})
export class PacijentDetailComponent implements OnInit {

  pacijent: IPacijent;

  constructor(private pacijentService: PacijentService, private route: ActivatedRoute) { }

  public getPacijentById(id: number): void {
    this.pacijentService.getPacijentById(id).subscribe(res => {
      this.pacijent = res;
    })
  }

  ngOnInit() {
    this.getPacijentById(this.route.snapshot.params.id);
  }

}
