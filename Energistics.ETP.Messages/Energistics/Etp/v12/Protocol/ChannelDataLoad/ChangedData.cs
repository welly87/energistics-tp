// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	
	public class ChangedData
	{
		private Energistics.Etp.v12.Datatypes.Object.IndexInterval _changedInterval;
		private List<Energistics.Etp.v12.Datatypes.ChannelData.DataItem> _data;
		public Energistics.Etp.v12.Datatypes.Object.IndexInterval ChangedInterval
		{
			get
			{
				return this._changedInterval;
			}
			set
			{
				this._changedInterval = value;
			}
		}
		public List<Energistics.Etp.v12.Datatypes.ChannelData.DataItem> Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
	}
}
