// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObjectNotification
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	
	public class PartsReplacedByRange
	{
		private string _uri;
		private Energistics.Etp.v12.Datatypes.Object.IndexInterval _deletedInterval;
		private bool _includeOverlappingIntervals;
		private string _contentType;
		private string _uid;
		private byte[] _data;
		private long _changeTime;
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
		public Energistics.Etp.v12.Datatypes.Object.IndexInterval DeletedInterval
		{
			get
			{
				return this._deletedInterval;
			}
			set
			{
				this._deletedInterval = value;
			}
		}
		public bool IncludeOverlappingIntervals
		{
			get
			{
				return this._includeOverlappingIntervals;
			}
			set
			{
				this._includeOverlappingIntervals = value;
			}
		}
		public string ContentType
		{
			get
			{
				return this._contentType;
			}
			set
			{
				this._contentType = value;
			}
		}
		public string Uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				this._uid = value;
			}
		}
		public byte[] Data
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
		public long ChangeTime
		{
			get
			{
				return this._changeTime;
			}
			set
			{
				this._changeTime = value;
			}
		}
	}
}
