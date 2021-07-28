import type { FullAuditedEntityDto } from '@abp/ng.core';

export interface CreatePurchaseDto {
  pBookId?: string;
  quantity: number;
}

export interface PurchaseDto extends FullAuditedEntityDto<string> {
  pBookId?: string;
  totalCost: number;
  quantity: number;
  updateFlag: boolean;
  stockToUpdate: number;
}

export interface UpdatePurchaseDto {
  quantity: number;
}
