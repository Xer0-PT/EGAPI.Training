import type { CreatePurchaseDto, PurchaseDto, StoreBookNameLookUpDto, UpdatePurchaseDto } from './models';
import { RestService } from '@abp/ng.core';
import type { ListResultDto, PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PurchaseService {
  apiName = 'Default';

  create = (input: CreatePurchaseDto) =>
    this.restService.request<any, PurchaseDto>({
      method: 'POST',
      url: '/api/app/purchase',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/purchase/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, PurchaseDto>({
      method: 'GET',
      url: `/api/app/purchase/${id}`,
    },
    { apiName: this.apiName });

  getBookName = () =>
    this.restService.request<any, ListResultDto<StoreBookNameLookUpDto>>({
      method: 'GET',
      url: '/api/app/purchase/book-name',
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<PurchaseDto>>({
      method: 'GET',
      url: '/api/app/purchase',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: UpdatePurchaseDto) =>
    this.restService.request<any, PurchaseDto>({
      method: 'PUT',
      url: `/api/app/purchase/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
