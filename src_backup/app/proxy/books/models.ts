import type { FullAuditedEntityDto } from '@abp/ng.core';

export interface CreateStoreBookDto {
  id?: string;
  name?: string;
  price: number;
  stock: number;
}

export interface StoreBookDto extends FullAuditedEntityDto<string> {
  name?: string;
  price: number;
  stock: number;
}

export interface UpdateStoreBookDto {
  name?: string;
  price: number;
  stock: number;
}
