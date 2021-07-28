import type { EntityDto, FullAuditedEntityDto } from '@abp/ng.core';

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
