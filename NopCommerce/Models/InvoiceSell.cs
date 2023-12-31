﻿using System;
using System.Collections.Generic;

namespace NopCommerce.Models;

public partial class InvoiceSell
{
    public decimal BuildingNo { get; set; }

    public long InvoiceNo { get; set; }

    public string UserNumber { get; set; } = null!;

    public short BillTypeNo { get; set; }

    public short? BillTypeSubNo { get; set; }

    public decimal StoreNo { get; set; }

    public string AName { get; set; } = null!;

    public string? EName { get; set; }

    public bool? IsCash { get; set; }

    public DateTime DateG { get; set; }

    public string? DateH { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryDateH { get; set; }

    public bool? IsDelivered { get; set; }

    public DateTime? DeliveredDate { get; set; }

    public string? DeliveredDateH { get; set; }

    public bool? IsOutDelivery { get; set; }

    public long? InvoiceJobStatusNo { get; set; }

    public long? InvoiceStatusNo { get; set; }

    public long? ShipType { get; set; }

    public decimal? ShipCost { get; set; }

    public string? ShipTo { get; set; }

    public long? BillToTypeNo { get; set; }

    public decimal? BillToBuildingNo { get; set; }

    public string? BillTo { get; set; }

    public bool? IsInventory1GaveIt { get; set; }

    public long? Inventory1StaffNo { get; set; }

    public bool? IsInventory2ReceivedIt { get; set; }

    public long? Inventory2StaffNo { get; set; }

    public long? DepositNo { get; set; }

    public long? ItemStatus { get; set; }

    public bool? IsPostedStock { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsVoid { get; set; }

    public bool? IsPosted { get; set; }

    public bool? IsGlposted { get; set; }

    public bool? IsPayments { get; set; }

    public bool? IsFastInvoice { get; set; }

    public bool? IsDeposited { get; set; }

    public bool? IsCleared { get; set; }

    public decimal? AmountLeftAfterAllBills { get; set; }

    public decimal? CollectedAmountFromOtherBills { get; set; }

    public string? Note { get; set; }

    public bool? IsItemOrUnit { get; set; }

    public long? PersonNo2 { get; set; }

    public int? CarNo { get; set; }

    public long? DriverNo { get; set; }

    public string? DriverName { get; set; }

    public bool? IsUseInOutInvoice { get; set; }

    public decimal? RegionNo { get; set; }

    public bool? IsAccountingForOthers { get; set; }

    public decimal? AccountNoPay { get; set; }

    public decimal? AccountNoShip { get; set; }

    public decimal? AccountNoDiscount { get; set; }

    public string? NamePay { get; set; }

    public string? NameDiscount { get; set; }

    public string? NameShip { get; set; }

    public long? BillNo { get; set; }

    public decimal? ProjectNo { get; set; }

    public decimal? AccountNo { get; set; }

    public decimal? AccountNoSecond { get; set; }

    public long? AgentNo { get; set; }

    public decimal? PayBillNo { get; set; }

    public long? PersonNo { get; set; }

    public long? ManPosted { get; set; }

    public long? ManGlposted { get; set; }

    public long? ManVoid { get; set; }

    public string? Telephone { get; set; }

    public decimal? SumPayed { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? SubTotalDiscount { get; set; }

    public decimal? SubNetTotal { get; set; }

    public decimal? SubNetTotalPlusTax { get; set; }

    public int? SubCount { get; set; }

    public decimal? SubLeftQuantity { get; set; }

    public decimal? SubQuantity { get; set; }

    public decimal? AmountCalculated { get; set; }

    public decimal? Discount { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? AmountPayed01 { get; set; }

    public decimal? AmountPayed02 { get; set; }

    public decimal? AmountPayed03 { get; set; }

    public decimal? AmountPayed04 { get; set; }

    public decimal? AmountPayed05 { get; set; }

    public decimal? AmountLeft { get; set; }

    public decimal? AmountCalculatedPayed { get; set; }

    public DateTime? RequestShipDate { get; set; }

    public short? PaymentTermsId { get; set; }

    public DateTime? DueDate { get; set; }

    public short? PricingSchemeId { get; set; }

    public DateTime? PickedDate { get; set; }

    public DateTime? PackedDate { get; set; }

    public bool? IsCompleted { get; set; }

    public short? TaxingSchemeNo { get; set; }

    public decimal? TaxRate1Percentage { get; set; }

    public decimal? TaxRate2Percentage { get; set; }

    public bool? IsCalculateTax2OnTax1 { get; set; }

    public string? TaxRate1eName { get; set; }

    public string? TaxRate2eName { get; set; }

    public bool? IsTax1OnShipping { get; set; }

    public bool? IsTax2OnShipping { get; set; }

    public string? TaxRate1aName { get; set; }

    public string? TaxRate2aName { get; set; }

    public short? TaxRateNo2 { get; set; }

    public decimal? TaxRate1Total { get; set; }

    public decimal? TaxRate2Total { get; set; }

    public bool? IsOneInvoiceUploaded { get; set; }

    public short? TaxRateNo { get; set; }

    public decimal? CashRegisterNoBuildingNo { get; set; }

    public string? InvoiceVatid { get; set; }

    public decimal? ClientVendorNo { get; set; }

    public bool? IsUploadedToMainBranch { get; set; }

    public bool? IsPostedToTransactions { get; set; }

    public DateTime? DateGPerDay { get; set; }

    public int? DateGPerMonth { get; set; }

    public int? DateGPerYearQuarter { get; set; }

    public int? DateGPerYearHalf { get; set; }

    public int? DateGPerYear { get; set; }

    public short? VattypeNo { get; set; }

    public short? VatgroupNo { get; set; }

    public decimal? ProfitMarginTotal { get; set; }

    public DateTime? DateGPosted { get; set; }

    public DateTime? DateGGlposted { get; set; }

    public string? MainContact1 { get; set; }

    public string? MainContact2 { get; set; }

    public string? MainContact3 { get; set; }

    public string? AmountPayed01VoucherNo { get; set; }

    public string? AmountPayed02VoucherNo { get; set; }

    public string? AmountPayed03VoucherNo { get; set; }

    public string? AmountPayed04VoucherNo { get; set; }

    public string? AmountPayed05VoucherNo { get; set; }

    public decimal? AmountPayed01BankAccountNo { get; set; }

    public decimal? AmountPayed02BankAccountNo { get; set; }

    public decimal? AmountPayed03BankAccountNo { get; set; }

    public decimal? AmountPayed04BankAccountNo { get; set; }

    public decimal? AmountPayed05BankAccountNo { get; set; }

    public decimal? CustomerCashGiven { get; set; }

    public decimal? CustomerCashReturned { get; set; }

    public decimal? PriceDifferenceFromFirstPriceTotal { get; set; }

    public int? PrintNumOfCopies { get; set; }

    public DateTime? PrintDateG { get; set; }

    public DateTime? LeftMoneyPaymentDate { get; set; }

    public long? NormalCustomerTypeNo { get; set; }

    public bool? IsPrintPartial { get; set; }

    public decimal? CardAmountVisa { get; set; }

    public decimal? CardAmountSpan { get; set; }

    public int? DailyBillNo { get; set; }

    public decimal? RunningCostAvgDiffrenceWhithPriceTotal { get; set; }

    public decimal? ProfitMarginTotalFromAvgCost { get; set; }

    public decimal? RunningCostAvgTotal { get; set; }

    public decimal? BuyPriceCostPriceTotal { get; set; }

    public decimal? PrimaryUnitQuantityTotal { get; set; }

    public string? PaperBillNum { get; set; }

    public string? GazElectricInNum { get; set; }

    public string? GaztElectricOutNum { get; set; }

    public bool? IsReturnedFullyByReturnInvoice { get; set; }

    public DateTime? IsReturnedFullyByReturnInvoiceDate { get; set; }

    public decimal? WeightTotal { get; set; }

    public long? StaffNo1PersonNo { get; set; }

    public long? StaffNo2PersonNo { get; set; }

    public long? StaffNo3PersonNo { get; set; }

    public long? ExportImportType { get; set; }

    public long? BillCreatorAsOf { get; set; }

    public string? Idcard { get; set; }

    public long? BillPaperType { get; set; }

    public string? PaymentTypes { get; set; }

    public decimal? SubNetTotalExecludingTax { get; set; }

    public decimal? DeviceMileage { get; set; }

    public int? DeviceMakerNo { get; set; }

    public string? DeviceModel { get; set; }

    public string? DevicePlate { get; set; }

    public string? DeviceSerial1 { get; set; }

    public string? DeviceSerial2 { get; set; }

    public decimal? DeviceNextMileage { get; set; }

    public DateTime? DeviceNextServiceDate { get; set; }

    public string? DeviceNextServiceDateH { get; set; }

    public int? DeviceMakeYear { get; set; }

    public short? InvBillTypeNo { get; set; }

    public decimal? InvBuildingNo { get; set; }

    public long? InvInvoiceNo { get; set; }

    public string? InvUserNumber { get; set; }

    public decimal? CalculatedPayed { get; set; }

    public decimal? AmountPayed { get; set; }

    public decimal? CalculatedCreditAmount { get; set; }

    public decimal? CalculatedDebitAmount { get; set; }

    public bool? IsCreateGlass { get; set; }

    public long? RentType { get; set; }

    public DateTime? RentDate { get; set; }

    public DateTime? RentReturnDate { get; set; }

    public decimal? RentQuantity { get; set; }

    public int? Service { get; set; }

    public bool? IsHangerOrFold { get; set; }

    public bool? IsSpot { get; set; }

    public bool? IsFastCleaning { get; set; }

    public long? StarchNo { get; set; }

    public long? BlueWeightNo { get; set; }

    public bool? IsLost { get; set; }

    public bool? IsPaperInvoiceReturned { get; set; }

    public long? SpoilTypeNo { get; set; }

    public decimal? TrainingHourseToBeGiven { get; set; }

    public decimal? TrainingHourseLeft { get; set; }

    public string? GaztInvoiceNumber { get; set; }

    public string? GaztUniqueInvoiceIdentifier { get; set; }

    public short? GaztInvoiceTypeCode { get; set; }

    public short? GaztInvoiceTypeCodeSubType { get; set; }

    public DateTime? GaztLatestDeliveryDate { get; set; }

    public string? GaztInvoiceHash { get; set; }

    public string? GaztPreviousInvoiceHash { get; set; }

    public byte[]? RowTimestamp { get; set; }
}
