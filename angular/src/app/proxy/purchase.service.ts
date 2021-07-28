import type { CreatePurchaseDto, PurchaseDto, StoreBookNameLookUpDto, UpdatePurchaseDto } from './models';
import { RestService } from '@abp/ng.core';
import type { ListResultDto, PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PurchaseService {
  apiName = 'gateway';

  create = (input: CreatePurchaseDto) =>
    this.restService.request<any, PurchaseDto>({
      method: 'POST',
      url: '/gateway/purchase',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/gateway/purchase/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, PurchaseDto>({
      method: 'GET',
      url: `/gateway/purchase/${id}`,
    },
    { apiName: this.apiName });

  getBookName = () =>
    this.restService.request<any, ListResultDto<StoreBookNameLookUpDto>>({
      method: 'GET',
      url: '/gateway/purchase/book-name',
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<PurchaseDto>>({
      method: 'GET',
      url: '/gateway/purchase',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: UpdatePurchaseDto) =>
    this.restService.request<any, PurchaseDto>({
      method: 'PUT',
      url: `/gateway/purchase/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
