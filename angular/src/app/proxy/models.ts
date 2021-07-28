import type { EntityDto, FullAuditedEntityDto } from '@abp/ng.core';

// Books

export interface BookDto extends FullAuditedEntityDto<string> {
  name?: string;
  price: number;
  stock: number;
}

export interface CreateBookDto {
  name?: string;
  price: number;
  stock: number;
}

export interface UpdateBookDto {
  name?: string;
  price: number;
  stock: number;
}


// Purchases

export interface CreatePurchaseDto {
  pBookId?: string;
  quantity: number;
  bookName?: string;
}

export interface PurchaseDto extends FullAuditedEntityDto<string> {
  pBookId?: string;
  totalCost: number;
  quantity: number;
  updateFlag: boolean;
  stockToUpdate: number;
  bookName?: string;
}

export interface StoreBookNameLookUpDto extends EntityDto<string> {
  bookName?: string;
}

export interface UpdatePurchaseDto {
  quantity: number;
}

// StoreBooks

export interface StoreBookDto extends FullAuditedEntityDto<string> {
  name?: string;
  price: number;
  stock: number;
}
