// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes.Object
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	
	public class SubscriptionInfo
	{
		private string _uri;
		private Energistics.Etp.v12.Datatypes.Uuid _requestUuid;
		private bool _includeObjectData;
		private long _startTime;
		private List<System.String> _contentTypes;
		public string Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Uuid RequestUuid
		{
			get
			{
				return this._requestUuid;
			}
			set
			{
				this._requestUuid = value;
			}
		}
		public bool IncludeObjectData
		{
			get
			{
				return this._includeObjectData;
			}
			set
			{
				this._includeObjectData = value;
			}
		}
		public long StartTime
		{
			get
			{
				return this._startTime;
			}
			set
			{
				this._startTime = value;
			}
		}
		public List<System.String> ContentTypes
		{
			get
			{
				return this._contentTypes;
			}
			set
			{
				this._contentTypes = value;
			}
		}
	}
}
