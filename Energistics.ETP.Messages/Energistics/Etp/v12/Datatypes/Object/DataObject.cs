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
	
	public class DataObject
	{
		private Energistics.Etp.v12.Datatypes.Object.Resource _resource;
		private byte[] _data;
		public Energistics.Etp.v12.Datatypes.Object.Resource Resource
		{
			get
			{
				return this._resource;
			}
			set
			{
				this._resource = value;
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
	}
}