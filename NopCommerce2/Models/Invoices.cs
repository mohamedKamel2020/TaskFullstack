namespace NopCommerce2.Models
{
	public class Invoices
	{
		public IList<InvoiceSellUnit> invoiceSellUnit { get; set; }
		public InvoiceSell invoiceSell { get; set; }
	}
}
