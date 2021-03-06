//
// Class	:	BDCustomerAccountBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	6/13/2015 10:16:23 AM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	/// <summary>
	/// Class for the properties of the object
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class BDCustomerAccountBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? CustomerAccountNumber {get;set;}

		[DataMember]
		public int? CustomerID {get;set;}

		[DataMember]
		public int? SalesInvoiceId {get;set;}

		[DataMember]
		public DateTime? SalesDate {get;set;}

		[DataMember]
		public string InvoiceNumber {get;set;}

		[DataMember]
		public decimal? TotalPrice {get;set;}

		[DataMember]
		public decimal? PaidAmount {get;set;}

		[DataMember]
		public decimal? RemainingAmount {get;set;}

		[DataMember]
		public bool? IsVoid {get;set;}

		[DataMember]
		public int? CreatedBy {get;set;}

		[DataMember]
		public DateTime? CreateDate {get;set;}

		[DataMember]
		public int? UpdatedBy {get;set;}

		[DataMember]
		public DateTime? UpdateDate {get;set;}

		[DataMember]
		public bool? IsDeleted {get;set;}

		[DataMember]
		public int? DeletedBy {get;set;}

		[DataMember]
		public DateTime? DeletedDate {get;set;}

		[DataMember]
		public decimal? Depit {get;set;}

		[DataMember]
		public decimal? Credit {get;set;}

		[DataMember]
		public int? ChequeNumber {get;set;}

		[DataMember]
		public string InvoiceType {get;set;}

		[DataMember]
		public DateTime? LstDayToPay {get;set;}

		
		#endregion
	}
}
			
