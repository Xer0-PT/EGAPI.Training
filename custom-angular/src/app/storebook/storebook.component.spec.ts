import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StorebookComponent } from './storebook.component';

describe('StorebookComponent', () => {
  let component: StorebookComponent;
  let fixture: ComponentFixture<StorebookComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StorebookComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StorebookComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
