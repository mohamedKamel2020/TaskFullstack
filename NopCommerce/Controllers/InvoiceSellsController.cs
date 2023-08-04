using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NopCommerce.Models;

namespace NopCommerce.Controllers
{
    public class InvoiceSellsController : Controller
    {
        private readonly NopCommerceContext _context;

        public InvoiceSellsController(NopCommerceContext context)
        {
            _context = context;
        }

        // GET: InvoiceSells
        public async Task<IActionResult> Index()
        {
              return _context.InvoiceSells != null ? 
                          View(await _context.InvoiceSells.ToListAsync()) :
                          Problem("Entity set 'NopCommerceContext.InvoiceSells'  is null.");
        }

        // GET: InvoiceSells/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null || _context.InvoiceSells == null)
            {
                return NotFound();
            }

            var invoiceSell = await _context.InvoiceSells
                .FirstOrDefaultAsync(m => m.BuildingNo == id);
            if (invoiceSell == null)
            {
                return NotFound();
            }

            return View(invoiceSell);
        }

        // GET: InvoiceSells/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InvoiceSells/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BuildingNo,InvoiceNo,UserNumber,BillTypeNo,BillTypeSubNo,StoreNo,AName,EName,IsCash,DateG,DateH,DeliveryDate,DeliveryDateH,IsDelivered,DeliveredDate,DeliveredDateH,IsOutDelivery,InvoiceJobStatusNo,InvoiceStatusNo,ShipType,ShipCost,ShipTo,BillToTypeNo,BillToBuildingNo,BillTo,IsInventory1GaveIt,Inventory1StaffNo,IsInventory2ReceivedIt,Inventory2StaffNo,DepositNo,ItemStatus,IsPostedStock,IsDeleted,IsVoid,IsPosted,IsGlposted,IsPayments,IsFastInvoice,IsDeposited,IsCleared,AmountLeftAfterAllBills,CollectedAmountFromOtherBills,Note,IsItemOrUnit,PersonNo2,CarNo,DriverNo,DriverName,IsUseInOutInvoice,RegionNo,IsAccountingForOthers,AccountNoPay,AccountNoShip,AccountNoDiscount,NamePay,NameDiscount,NameShip,BillNo,ProjectNo,AccountNo,AccountNoSecond,AgentNo,PayBillNo,PersonNo,ManPosted,ManGlposted,ManVoid,Telephone,SumPayed,SubTotal,SubTotalDiscount,SubNetTotal,SubNetTotalPlusTax,SubCount,SubLeftQuantity,SubQuantity,AmountCalculated,Discount,TotalDiscount,AmountPayed01,AmountPayed02,AmountPayed03,AmountPayed04,AmountPayed05,AmountLeft,AmountCalculatedPayed,RequestShipDate,PaymentTermsId,DueDate,PricingSchemeId,PickedDate,PackedDate,IsCompleted,TaxingSchemeNo,TaxRate1Percentage,TaxRate2Percentage,IsCalculateTax2OnTax1,TaxRate1eName,TaxRate2eName,IsTax1OnShipping,IsTax2OnShipping,TaxRate1aName,TaxRate2aName,TaxRateNo2,TaxRate1Total,TaxRate2Total,IsOneInvoiceUploaded,TaxRateNo,CashRegisterNoBuildingNo,InvoiceVatid,ClientVendorNo,IsUploadedToMainBranch,IsPostedToTransactions,DateGPerDay,DateGPerMonth,DateGPerYearQuarter,DateGPerYearHalf,DateGPerYear,VattypeNo,VatgroupNo,ProfitMarginTotal,DateGPosted,DateGGlposted,MainContact1,MainContact2,MainContact3,AmountPayed01VoucherNo,AmountPayed02VoucherNo,AmountPayed03VoucherNo,AmountPayed04VoucherNo,AmountPayed05VoucherNo,AmountPayed01BankAccountNo,AmountPayed02BankAccountNo,AmountPayed03BankAccountNo,AmountPayed04BankAccountNo,AmountPayed05BankAccountNo,CustomerCashGiven,CustomerCashReturned,PriceDifferenceFromFirstPriceTotal,PrintNumOfCopies,PrintDateG,LeftMoneyPaymentDate,NormalCustomerTypeNo,IsPrintPartial,CardAmountVisa,CardAmountSpan,DailyBillNo,RunningCostAvgDiffrenceWhithPriceTotal,ProfitMarginTotalFromAvgCost,RunningCostAvgTotal,BuyPriceCostPriceTotal,PrimaryUnitQuantityTotal,PaperBillNum,GazElectricInNum,GaztElectricOutNum,IsReturnedFullyByReturnInvoice,IsReturnedFullyByReturnInvoiceDate,WeightTotal,StaffNo1PersonNo,StaffNo2PersonNo,StaffNo3PersonNo,ExportImportType,BillCreatorAsOf,Idcard,BillPaperType,PaymentTypes,SubNetTotalExecludingTax,DeviceMileage,DeviceMakerNo,DeviceModel,DevicePlate,DeviceSerial1,DeviceSerial2,DeviceNextMileage,DeviceNextServiceDate,DeviceNextServiceDateH,DeviceMakeYear,InvBillTypeNo,InvBuildingNo,InvInvoiceNo,InvUserNumber,CalculatedPayed,AmountPayed,CalculatedCreditAmount,CalculatedDebitAmount,IsCreateGlass,RentType,RentDate,RentReturnDate,RentQuantity,Service,IsHangerOrFold,IsSpot,IsFastCleaning,StarchNo,BlueWeightNo,IsLost,IsPaperInvoiceReturned,SpoilTypeNo,TrainingHourseToBeGiven,TrainingHourseLeft,GaztInvoiceNumber,GaztUniqueInvoiceIdentifier,GaztInvoiceTypeCode,GaztInvoiceTypeCodeSubType,GaztLatestDeliveryDate,GaztInvoiceHash,GaztPreviousInvoiceHash,RowTimestamp")] InvoiceSell invoiceSell)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invoiceSell);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(invoiceSell);
        }

        // GET: InvoiceSells/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null || _context.InvoiceSells == null)
            {
                return NotFound();
            }

            var invoiceSell = await _context.InvoiceSells.FindAsync(id);
            if (invoiceSell == null)
            {
                return NotFound();
            }
            return View(invoiceSell);
        }

        // POST: InvoiceSells/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("BuildingNo,InvoiceNo,UserNumber,BillTypeNo,BillTypeSubNo,StoreNo,AName,EName,IsCash,DateG,DateH,DeliveryDate,DeliveryDateH,IsDelivered,DeliveredDate,DeliveredDateH,IsOutDelivery,InvoiceJobStatusNo,InvoiceStatusNo,ShipType,ShipCost,ShipTo,BillToTypeNo,BillToBuildingNo,BillTo,IsInventory1GaveIt,Inventory1StaffNo,IsInventory2ReceivedIt,Inventory2StaffNo,DepositNo,ItemStatus,IsPostedStock,IsDeleted,IsVoid,IsPosted,IsGlposted,IsPayments,IsFastInvoice,IsDeposited,IsCleared,AmountLeftAfterAllBills,CollectedAmountFromOtherBills,Note,IsItemOrUnit,PersonNo2,CarNo,DriverNo,DriverName,IsUseInOutInvoice,RegionNo,IsAccountingForOthers,AccountNoPay,AccountNoShip,AccountNoDiscount,NamePay,NameDiscount,NameShip,BillNo,ProjectNo,AccountNo,AccountNoSecond,AgentNo,PayBillNo,PersonNo,ManPosted,ManGlposted,ManVoid,Telephone,SumPayed,SubTotal,SubTotalDiscount,SubNetTotal,SubNetTotalPlusTax,SubCount,SubLeftQuantity,SubQuantity,AmountCalculated,Discount,TotalDiscount,AmountPayed01,AmountPayed02,AmountPayed03,AmountPayed04,AmountPayed05,AmountLeft,AmountCalculatedPayed,RequestShipDate,PaymentTermsId,DueDate,PricingSchemeId,PickedDate,PackedDate,IsCompleted,TaxingSchemeNo,TaxRate1Percentage,TaxRate2Percentage,IsCalculateTax2OnTax1,TaxRate1eName,TaxRate2eName,IsTax1OnShipping,IsTax2OnShipping,TaxRate1aName,TaxRate2aName,TaxRateNo2,TaxRate1Total,TaxRate2Total,IsOneInvoiceUploaded,TaxRateNo,CashRegisterNoBuildingNo,InvoiceVatid,ClientVendorNo,IsUploadedToMainBranch,IsPostedToTransactions,DateGPerDay,DateGPerMonth,DateGPerYearQuarter,DateGPerYearHalf,DateGPerYear,VattypeNo,VatgroupNo,ProfitMarginTotal,DateGPosted,DateGGlposted,MainContact1,MainContact2,MainContact3,AmountPayed01VoucherNo,AmountPayed02VoucherNo,AmountPayed03VoucherNo,AmountPayed04VoucherNo,AmountPayed05VoucherNo,AmountPayed01BankAccountNo,AmountPayed02BankAccountNo,AmountPayed03BankAccountNo,AmountPayed04BankAccountNo,AmountPayed05BankAccountNo,CustomerCashGiven,CustomerCashReturned,PriceDifferenceFromFirstPriceTotal,PrintNumOfCopies,PrintDateG,LeftMoneyPaymentDate,NormalCustomerTypeNo,IsPrintPartial,CardAmountVisa,CardAmountSpan,DailyBillNo,RunningCostAvgDiffrenceWhithPriceTotal,ProfitMarginTotalFromAvgCost,RunningCostAvgTotal,BuyPriceCostPriceTotal,PrimaryUnitQuantityTotal,PaperBillNum,GazElectricInNum,GaztElectricOutNum,IsReturnedFullyByReturnInvoice,IsReturnedFullyByReturnInvoiceDate,WeightTotal,StaffNo1PersonNo,StaffNo2PersonNo,StaffNo3PersonNo,ExportImportType,BillCreatorAsOf,Idcard,BillPaperType,PaymentTypes,SubNetTotalExecludingTax,DeviceMileage,DeviceMakerNo,DeviceModel,DevicePlate,DeviceSerial1,DeviceSerial2,DeviceNextMileage,DeviceNextServiceDate,DeviceNextServiceDateH,DeviceMakeYear,InvBillTypeNo,InvBuildingNo,InvInvoiceNo,InvUserNumber,CalculatedPayed,AmountPayed,CalculatedCreditAmount,CalculatedDebitAmount,IsCreateGlass,RentType,RentDate,RentReturnDate,RentQuantity,Service,IsHangerOrFold,IsSpot,IsFastCleaning,StarchNo,BlueWeightNo,IsLost,IsPaperInvoiceReturned,SpoilTypeNo,TrainingHourseToBeGiven,TrainingHourseLeft,GaztInvoiceNumber,GaztUniqueInvoiceIdentifier,GaztInvoiceTypeCode,GaztInvoiceTypeCodeSubType,GaztLatestDeliveryDate,GaztInvoiceHash,GaztPreviousInvoiceHash,RowTimestamp")] InvoiceSell invoiceSell)
        {
            if (id != invoiceSell.BuildingNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoiceSell);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceSellExists(invoiceSell.BuildingNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(invoiceSell);
        }

        // GET: InvoiceSells/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null || _context.InvoiceSells == null)
            {
                return NotFound();
            }

            var invoiceSell = await _context.InvoiceSells
                .FirstOrDefaultAsync(m => m.BuildingNo == id);
            if (invoiceSell == null)
            {
                return NotFound();
            }

            return View(invoiceSell);
        }

        // POST: InvoiceSells/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            if (_context.InvoiceSells == null)
            {
                return Problem("Entity set 'NopCommerceContext.InvoiceSells'  is null.");
            }
            var invoiceSell = await _context.InvoiceSells.FindAsync(id);
            if (invoiceSell != null)
            {
                _context.InvoiceSells.Remove(invoiceSell);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceSellExists(decimal id)
        {
          return (_context.InvoiceSells?.Any(e => e.BuildingNo == id)).GetValueOrDefault();
        }
    }
}
