// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	
	public class IndexValue
	{
		private object _item;
		[Microsoft.Hadoop.Avro.AvroUnion(typeof(Microsoft.Hadoop.Avro.AvroNull), typeof(long), typeof(double))]
		public object Item
		{
			get
			{
				return this._item;
			}
			set
			{
				this._item = value;
			}
		}
	}
}
