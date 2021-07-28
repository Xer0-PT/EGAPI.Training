import type { BookDto, CreateBookDto, UpdateBookDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class BookService {
  apiName = 'gateway';

  create = (input: CreateBookDto) =>
    this.restService.request<any, BookDto>({
      method: 'POST',
      url: '/gateway/book',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/gateway/book/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, BookDto>({
      method: 'GET',
      url: `/gateway/book/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<BookDto>>({
      method: 'GET',
      url: '/gateway/book',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: UpdateBookDto) =>
    this.restService.request<any, BookDto>({
      method: 'PUT',
      url: `/gateway/book/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
