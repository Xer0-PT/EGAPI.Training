import { Component, OnInit } from '@angular/core';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { StoreBookService, StoreBookDto} from '@proxy';

@Component({
  selector: 'app-storebook',
  templateUrl: './storebook.component.html',
  styleUrls: ['./storebook.component.scss'],
  providers: [ListService],
})
export class StorebookComponent implements OnInit {

  storeBook = { items: [], totalCount: 0 } as PagedResultDto<StoreBookDto>;


  constructor(
    public readonly list: ListService,
    private storeBookService: StoreBookService,
  ) { }

  ngOnInit(): void {
    const storeBookStreamCreator = (query) => this.storeBookService.getList(query);

    this.list.hookToQuery(storeBookStreamCreator).subscribe((response) => {
      this.storeBook = response;
    });
  }

}
