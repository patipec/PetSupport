import {AfterViewInit, Component, ElementRef, NgZone, OnDestroy, OnInit, ViewChild} from '@angular/core';
import {BehaviorSubject} from 'rxjs';
import ResizeObserver from 'resize-observer-polyfill';

@Component({
  selector: 'app-pettsiters',
  templateUrl: './pettsiters.component.html',
  styleUrls: ['./pettsiters.component.css']
})
export class PettsittersComponent implements OnInit, AfterViewInit, OnDestroy {
  cols = 6;
  colspanFilter = 1;
  colspanMap = 2;
  colspanList = 3;
  width$ = new BehaviorSubject<number>(0);
  observer;
  @ViewChild('host')
  public host: ElementRef;

  constructor(
    private zone: NgZone
  ) {
  }

  ngAfterViewInit(): void {
    console.log(this.host.nativeElement);
    this.observer = new ResizeObserver(entries => {
      console.log(entries);
      this.zone.run(() => {
        this.width$.next(entries[0].contentRect.width);
      });
    });

    this.observer.observe(this.host.nativeElement);
  }

  ngOnDestroy(): void {
    this.observer.unobserve(this.host.nativeElement);
  }

  ngOnInit(): void {
    this.width$.subscribe((data) => {

        if (data < 1000) {
          this.cols = 1;
          this.colspanFilter = 1;
          this.colspanMap = 1;
          this.colspanList = 1;
          return;
        }
        this.cols = 6;
        this.colspanFilter = 1;
        this.colspanMap = 2;
        this.colspanList = 3;
      }
    );
  }

}
