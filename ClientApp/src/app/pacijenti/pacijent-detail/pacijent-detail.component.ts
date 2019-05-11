import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PacijentService } from '../pacijent.service';
import { IPacijent } from '../pacijent';
import {Router} from "@angular/router"

@Component({
  selector: 'app-pacijent-detail',
  templateUrl: './pacijent-detail.component.html',
  styleUrls: ['./pacijent-detail.component.css']
})
export class PacijentDetailComponent implements OnInit {

  pacijent: IPacijent;
  errorMessage: string;
  id: number;

  constructor(private pacijentService: PacijentService, private route: ActivatedRoute, private router: Router) { }

  public getPacijentById(id: number): void {
    this.pacijentService.getPacijentById(id).subscribe(
      res => this.pacijent = res,
      error => this.errorMessage = <any>error
    );
  }

  public async removePacijent(){
    this.id = this.route.snapshot.params.id;
    if(confirm("Jeste li sigurni da želite izbrisati pacijenta?")){
      await this.pacijentService.removePacijent(this.id).subscribe(
        error => this.errorMessage = <any>error
      );
      this.router.navigate(['/pacijenti'])
    }
  }

  ngOnInit() {
    this.getPacijentById(this.route.snapshot.params.id);
  }

}
