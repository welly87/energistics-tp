// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Transaction
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	
	public class CommitTransactionResponse
	{
		private Energistics.Etp.v12.Datatypes.Uuid _transactionUuid;
		private bool _successful;
		private string _failureReason;
		public Energistics.Etp.v12.Datatypes.Uuid TransactionUuid
		{
			get
			{
				return this._transactionUuid;
			}
			set
			{
				this._transactionUuid = value;
			}
		}
		public bool Successful
		{
			get
			{
				return this._successful;
			}
			set
			{
				this._successful = value;
			}
		}
		public string FailureReason
		{
			get
			{
				return this._failureReason;
			}
			set
			{
				this._failureReason = value;
			}
		}
	}
}
