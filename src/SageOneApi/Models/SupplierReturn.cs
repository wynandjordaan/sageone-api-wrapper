using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageOneApi.Models
{
	public class SupplierReturn : BaseModel
	{
		public string FromDocument { get; set; }
		public bool Locked { get; set; }
		public int SupplierId { get; set; }
		public string SupplierName { get; set; }
		public Supplier Supplier { get; set; }
		public string Modified { get; set; }
		public string Created { get; set; }
		public int StatusId { get; set; }
		public DateTime Date { get; set; }
		public bool Inclusive { get; set; }
		public double DiscountPercentage { get; set; }
		public string TaxReference { get; set; }
		public string DocumentNumber { get; set; }
		public string Reference { get; set; }
		public string Message { get; set; }
		public double Discount { get; set; }
		public double Exclusive { get; set; }
		public double Tax { get; set; }
		public double Rounding { get; set; }
		public double Total { get; set; }
		public double AmountDue { get; set; }
		public string PostalAddress01 { get; set; }
		public string PostalAddress02 { get; set; }
		public string PostalAddress03 { get; set; }
		public string PostalAddress04 { get; set; }
		public string PostalAddress05 { get; set; }
		public string DeliveryAddress01 { get; set; }
		public string DeliveryAddress02 { get; set; }
		public string DeliveryAddress03 { get; set; }
		public string DeliveryAddress04 { get; set; }
		public string DeliveryAddress05 { get; set; }
		public bool Printed { get; set; }
		public int CurrencyId { get; set; }
		public double ExchangeRate { get; set; }
		public int TaxPeriodId { get; set; }
		public bool Editable { get; set; }
		public bool HasAttachments { get; set; }
		public bool HasNotes { get; set; }
		public bool HasAnticipatedDate { get; set; }
		public string AnticipatedDate { get; set; }
		public string ExternalReference { get; set; }
		public List<CommercialDocumentLine> Lines { get; set; }
	}
}
