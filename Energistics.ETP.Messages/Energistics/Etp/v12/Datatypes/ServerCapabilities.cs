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
	
	public class ServerCapabilities
	{
		private string _applicationName;
		private string _applicationVersion;
		private List<Energistics.Etp.v12.Datatypes.SupportedProtocol> _supportedProtocols;
		private List<System.String> _supportedObjects;
		private Energistics.Etp.v12.Datatypes.Contact _contactInformation;
		private string _supportedEncodings;
		private List<System.String> _supportedCompression;
		public string ApplicationName
		{
			get
			{
				return this._applicationName;
			}
			set
			{
				this._applicationName = value;
			}
		}
		public string ApplicationVersion
		{
			get
			{
				return this._applicationVersion;
			}
			set
			{
				this._applicationVersion = value;
			}
		}
		public List<Energistics.Etp.v12.Datatypes.SupportedProtocol> SupportedProtocols
		{
			get
			{
				return this._supportedProtocols;
			}
			set
			{
				this._supportedProtocols = value;
			}
		}
		public List<System.String> SupportedObjects
		{
			get
			{
				return this._supportedObjects;
			}
			set
			{
				this._supportedObjects = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Contact ContactInformation
		{
			get
			{
				return this._contactInformation;
			}
			set
			{
				this._contactInformation = value;
			}
		}
		public string SupportedEncodings
		{
			get
			{
				return this._supportedEncodings;
			}
			set
			{
				this._supportedEncodings = value;
			}
		}
		public List<System.String> SupportedCompression
		{
			get
			{
				return this._supportedCompression;
			}
			set
			{
				this._supportedCompression = value;
			}
		}
	}
}
