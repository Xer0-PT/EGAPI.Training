import type { CreateStoreBookDto, StoreBookDto, UpdateStoreBookDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class StoreBookService {
  apiName = 'Default';

  create = (input: CreateStoreBookDto) =>
    this.restService.request<any, StoreBookDto>({
      method: 'POST',
      url: '/api/app/store-book',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/store-book/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, StoreBookDto>({
      method: 'GET',
      url: `/api/app/store-book/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<StoreBookDto>>({
      method: 'GET',
      url: '/api/app/store-book',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: UpdateStoreBookDto) =>
    this.restService.request<any, StoreBookDto>({
      method: 'PUT',
      url: `/api/app/store-book/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  updateStockByIdAndStock = (id: string, stock: number) =>
    this.restService.request<any, void>({
      method: 'PUT',
      url: `/api/app/store-book/${id}/stock`,
      params: { stock },
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
