// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataFrame
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	
	public class RequestChannelData
	{
		private string _uri;
		private Energistics.Etp.v12.Datatypes.Object.IndexInterval _requestedInterval;
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
		public Energistics.Etp.v12.Datatypes.Object.IndexInterval RequestedInterval
		{
			get
			{
				return this._requestedInterval;
			}
			set
			{
				this._requestedInterval = value;
			}
		}
	}
}
