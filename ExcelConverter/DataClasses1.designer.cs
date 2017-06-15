﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExcelConverter
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="iga")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBulkData33mm(BulkData33mm instance);
    partial void UpdateBulkData33mm(BulkData33mm instance);
    partial void DeleteBulkData33mm(BulkData33mm instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ExcelConverter.Properties.Settings.Default.igaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BulkData33mm> BulkData33mms
		{
			get
			{
				return this.GetTable<BulkData33mm>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BulkData33mm")]
	public partial class BulkData33mm : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Image1;
		
		private string _Image2;
		
		private string _Image3;
		
		private string _ProductType;
		
		private string _TankSize;
		
		private string _Supplier;
		
		private string _MarketSector;
		
		private string _Place;
		
		private string _Country;
		
		private string _CountryCode;
		
		private string _Remarks;
		
		private string _VoiceData;
		
		private string _Website;
		
		private string _CylinderRequired;
		
		private string _SalesForceInfo;
		
		private string _BarplusInfo;
		
		private string _AddedUser;
		
		private System.DateTime _AddedDate;
		
		private string _AddedIpAddress;
		
		private System.DateTime _UpdatedDate;
		
		private string _UpdatedUser;
		
		private string _RecordStatus;
		
		private string _Device;
		
		private string _UserLocationId;
		
		private string _RegionId;
		
		private System.Nullable<int> _CountryId;
		
		private string _RecordType;
		
		private string _CustomerNo;
		
		private System.Nullable<System.DateTime> _LastSyncDate;
		
		private string _Name;
		
		private string _Address;
		
		private string _Postcode;
		
		private System.Nullable<double> _Longitude;
		
		private System.Nullable<double> _Latitude;
		
		private System.Nullable<bool> _IsBarPlusData;
		
		private string _RepId;
		
		private string _RepName;
		
		private System.Nullable<bool> _RepNotified;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnImage1Changing(string value);
    partial void OnImage1Changed();
    partial void OnImage2Changing(string value);
    partial void OnImage2Changed();
    partial void OnImage3Changing(string value);
    partial void OnImage3Changed();
    partial void OnProductTypeChanging(string value);
    partial void OnProductTypeChanged();
    partial void OnTankSizeChanging(string value);
    partial void OnTankSizeChanged();
    partial void OnSupplierChanging(string value);
    partial void OnSupplierChanged();
    partial void OnMarketSectorChanging(string value);
    partial void OnMarketSectorChanged();
    partial void OnPlaceChanging(string value);
    partial void OnPlaceChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnCountryCodeChanging(string value);
    partial void OnCountryCodeChanged();
    partial void OnRemarksChanging(string value);
    partial void OnRemarksChanged();
    partial void OnVoiceDataChanging(string value);
    partial void OnVoiceDataChanged();
    partial void OnWebsiteChanging(string value);
    partial void OnWebsiteChanged();
    partial void OnCylinderRequiredChanging(string value);
    partial void OnCylinderRequiredChanged();
    partial void OnSalesForceInfoChanging(string value);
    partial void OnSalesForceInfoChanged();
    partial void OnBarplusInfoChanging(string value);
    partial void OnBarplusInfoChanged();
    partial void OnAddedUserChanging(string value);
    partial void OnAddedUserChanged();
    partial void OnAddedDateChanging(System.DateTime value);
    partial void OnAddedDateChanged();
    partial void OnAddedIpAddressChanging(string value);
    partial void OnAddedIpAddressChanged();
    partial void OnUpdatedDateChanging(System.DateTime value);
    partial void OnUpdatedDateChanged();
    partial void OnUpdatedUserChanging(string value);
    partial void OnUpdatedUserChanged();
    partial void OnRecordStatusChanging(string value);
    partial void OnRecordStatusChanged();
    partial void OnDeviceChanging(string value);
    partial void OnDeviceChanged();
    partial void OnUserLocationIdChanging(string value);
    partial void OnUserLocationIdChanged();
    partial void OnRegionIdChanging(string value);
    partial void OnRegionIdChanged();
    partial void OnCountryIdChanging(System.Nullable<int> value);
    partial void OnCountryIdChanged();
    partial void OnRecordTypeChanging(string value);
    partial void OnRecordTypeChanged();
    partial void OnCustomerNoChanging(string value);
    partial void OnCustomerNoChanged();
    partial void OnLastSyncDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastSyncDateChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPostcodeChanging(string value);
    partial void OnPostcodeChanged();
    partial void OnLongitudeChanging(System.Nullable<double> value);
    partial void OnLongitudeChanged();
    partial void OnLatitudeChanging(System.Nullable<double> value);
    partial void OnLatitudeChanged();
    partial void OnIsBarPlusDataChanging(System.Nullable<bool> value);
    partial void OnIsBarPlusDataChanged();
    partial void OnRepIdChanging(string value);
    partial void OnRepIdChanged();
    partial void OnRepNameChanging(string value);
    partial void OnRepNameChanged();
    partial void OnRepNotifiedChanging(System.Nullable<bool> value);
    partial void OnRepNotifiedChanged();
    #endregion
		
		public BulkData33mm()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image1", DbType="VarChar(MAX)")]
		public string Image1
		{
			get
			{
				return this._Image1;
			}
			set
			{
				if ((this._Image1 != value))
				{
					this.OnImage1Changing(value);
					this.SendPropertyChanging();
					this._Image1 = value;
					this.SendPropertyChanged("Image1");
					this.OnImage1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image2", DbType="VarChar(MAX)")]
		public string Image2
		{
			get
			{
				return this._Image2;
			}
			set
			{
				if ((this._Image2 != value))
				{
					this.OnImage2Changing(value);
					this.SendPropertyChanging();
					this._Image2 = value;
					this.SendPropertyChanged("Image2");
					this.OnImage2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image3", DbType="VarChar(MAX)")]
		public string Image3
		{
			get
			{
				return this._Image3;
			}
			set
			{
				if ((this._Image3 != value))
				{
					this.OnImage3Changing(value);
					this.SendPropertyChanging();
					this._Image3 = value;
					this.SendPropertyChanged("Image3");
					this.OnImage3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductType", DbType="NVarChar(500)")]
		public string ProductType
		{
			get
			{
				return this._ProductType;
			}
			set
			{
				if ((this._ProductType != value))
				{
					this.OnProductTypeChanging(value);
					this.SendPropertyChanging();
					this._ProductType = value;
					this.SendPropertyChanged("ProductType");
					this.OnProductTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TankSize", DbType="NVarChar(500)")]
		public string TankSize
		{
			get
			{
				return this._TankSize;
			}
			set
			{
				if ((this._TankSize != value))
				{
					this.OnTankSizeChanging(value);
					this.SendPropertyChanging();
					this._TankSize = value;
					this.SendPropertyChanged("TankSize");
					this.OnTankSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Supplier", DbType="NVarChar(500)")]
		public string Supplier
		{
			get
			{
				return this._Supplier;
			}
			set
			{
				if ((this._Supplier != value))
				{
					this.OnSupplierChanging(value);
					this.SendPropertyChanging();
					this._Supplier = value;
					this.SendPropertyChanged("Supplier");
					this.OnSupplierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarketSector", DbType="NVarChar(500)")]
		public string MarketSector
		{
			get
			{
				return this._MarketSector;
			}
			set
			{
				if ((this._MarketSector != value))
				{
					this.OnMarketSectorChanging(value);
					this.SendPropertyChanging();
					this._MarketSector = value;
					this.SendPropertyChanged("MarketSector");
					this.OnMarketSectorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Place", DbType="NVarChar(500)")]
		public string Place
		{
			get
			{
				return this._Place;
			}
			set
			{
				if ((this._Place != value))
				{
					this.OnPlaceChanging(value);
					this.SendPropertyChanging();
					this._Place = value;
					this.SendPropertyChanged("Place");
					this.OnPlaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(500)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryCode", DbType="NVarChar(500)")]
		public string CountryCode
		{
			get
			{
				return this._CountryCode;
			}
			set
			{
				if ((this._CountryCode != value))
				{
					this.OnCountryCodeChanging(value);
					this.SendPropertyChanging();
					this._CountryCode = value;
					this.SendPropertyChanged("CountryCode");
					this.OnCountryCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Remarks", DbType="NVarChar(500)")]
		public string Remarks
		{
			get
			{
				return this._Remarks;
			}
			set
			{
				if ((this._Remarks != value))
				{
					this.OnRemarksChanging(value);
					this.SendPropertyChanging();
					this._Remarks = value;
					this.SendPropertyChanged("Remarks");
					this.OnRemarksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VoiceData", DbType="NVarChar(500)")]
		public string VoiceData
		{
			get
			{
				return this._VoiceData;
			}
			set
			{
				if ((this._VoiceData != value))
				{
					this.OnVoiceDataChanging(value);
					this.SendPropertyChanging();
					this._VoiceData = value;
					this.SendPropertyChanged("VoiceData");
					this.OnVoiceDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Website", DbType="NVarChar(500)")]
		public string Website
		{
			get
			{
				return this._Website;
			}
			set
			{
				if ((this._Website != value))
				{
					this.OnWebsiteChanging(value);
					this.SendPropertyChanging();
					this._Website = value;
					this.SendPropertyChanged("Website");
					this.OnWebsiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CylinderRequired", DbType="NVarChar(500)")]
		public string CylinderRequired
		{
			get
			{
				return this._CylinderRequired;
			}
			set
			{
				if ((this._CylinderRequired != value))
				{
					this.OnCylinderRequiredChanging(value);
					this.SendPropertyChanging();
					this._CylinderRequired = value;
					this.SendPropertyChanged("CylinderRequired");
					this.OnCylinderRequiredChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesForceInfo", DbType="NVarChar(500)")]
		public string SalesForceInfo
		{
			get
			{
				return this._SalesForceInfo;
			}
			set
			{
				if ((this._SalesForceInfo != value))
				{
					this.OnSalesForceInfoChanging(value);
					this.SendPropertyChanging();
					this._SalesForceInfo = value;
					this.SendPropertyChanged("SalesForceInfo");
					this.OnSalesForceInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BarplusInfo", DbType="NVarChar(500)")]
		public string BarplusInfo
		{
			get
			{
				return this._BarplusInfo;
			}
			set
			{
				if ((this._BarplusInfo != value))
				{
					this.OnBarplusInfoChanging(value);
					this.SendPropertyChanging();
					this._BarplusInfo = value;
					this.SendPropertyChanged("BarplusInfo");
					this.OnBarplusInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddedUser", DbType="NVarChar(500)")]
		public string AddedUser
		{
			get
			{
				return this._AddedUser;
			}
			set
			{
				if ((this._AddedUser != value))
				{
					this.OnAddedUserChanging(value);
					this.SendPropertyChanging();
					this._AddedUser = value;
					this.SendPropertyChanged("AddedUser");
					this.OnAddedUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddedDate", DbType="DateTime NOT NULL")]
		public System.DateTime AddedDate
		{
			get
			{
				return this._AddedDate;
			}
			set
			{
				if ((this._AddedDate != value))
				{
					this.OnAddedDateChanging(value);
					this.SendPropertyChanging();
					this._AddedDate = value;
					this.SendPropertyChanged("AddedDate");
					this.OnAddedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddedIpAddress", DbType="NVarChar(500)")]
		public string AddedIpAddress
		{
			get
			{
				return this._AddedIpAddress;
			}
			set
			{
				if ((this._AddedIpAddress != value))
				{
					this.OnAddedIpAddressChanging(value);
					this.SendPropertyChanging();
					this._AddedIpAddress = value;
					this.SendPropertyChanged("AddedIpAddress");
					this.OnAddedIpAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedDate", DbType="DateTime NOT NULL")]
		public System.DateTime UpdatedDate
		{
			get
			{
				return this._UpdatedDate;
			}
			set
			{
				if ((this._UpdatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._UpdatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedUser", DbType="NVarChar(500)")]
		public string UpdatedUser
		{
			get
			{
				return this._UpdatedUser;
			}
			set
			{
				if ((this._UpdatedUser != value))
				{
					this.OnUpdatedUserChanging(value);
					this.SendPropertyChanging();
					this._UpdatedUser = value;
					this.SendPropertyChanged("UpdatedUser");
					this.OnUpdatedUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecordStatus", DbType="NVarChar(500)")]
		public string RecordStatus
		{
			get
			{
				return this._RecordStatus;
			}
			set
			{
				if ((this._RecordStatus != value))
				{
					this.OnRecordStatusChanging(value);
					this.SendPropertyChanging();
					this._RecordStatus = value;
					this.SendPropertyChanged("RecordStatus");
					this.OnRecordStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Device", DbType="NVarChar(50)")]
		public string Device
		{
			get
			{
				return this._Device;
			}
			set
			{
				if ((this._Device != value))
				{
					this.OnDeviceChanging(value);
					this.SendPropertyChanging();
					this._Device = value;
					this.SendPropertyChanged("Device");
					this.OnDeviceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserLocationId", DbType="NVarChar(50)")]
		public string UserLocationId
		{
			get
			{
				return this._UserLocationId;
			}
			set
			{
				if ((this._UserLocationId != value))
				{
					this.OnUserLocationIdChanging(value);
					this.SendPropertyChanging();
					this._UserLocationId = value;
					this.SendPropertyChanged("UserLocationId");
					this.OnUserLocationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegionId", DbType="NVarChar(50)")]
		public string RegionId
		{
			get
			{
				return this._RegionId;
			}
			set
			{
				if ((this._RegionId != value))
				{
					this.OnRegionIdChanging(value);
					this.SendPropertyChanging();
					this._RegionId = value;
					this.SendPropertyChanged("RegionId");
					this.OnRegionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryId", DbType="Int")]
		public System.Nullable<int> CountryId
		{
			get
			{
				return this._CountryId;
			}
			set
			{
				if ((this._CountryId != value))
				{
					this.OnCountryIdChanging(value);
					this.SendPropertyChanging();
					this._CountryId = value;
					this.SendPropertyChanged("CountryId");
					this.OnCountryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecordType", DbType="VarChar(3)")]
		public string RecordType
		{
			get
			{
				return this._RecordType;
			}
			set
			{
				if ((this._RecordType != value))
				{
					this.OnRecordTypeChanging(value);
					this.SendPropertyChanging();
					this._RecordType = value;
					this.SendPropertyChanged("RecordType");
					this.OnRecordTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerNo", DbType="NVarChar(50)")]
		public string CustomerNo
		{
			get
			{
				return this._CustomerNo;
			}
			set
			{
				if ((this._CustomerNo != value))
				{
					this.OnCustomerNoChanging(value);
					this.SendPropertyChanging();
					this._CustomerNo = value;
					this.SendPropertyChanged("CustomerNo");
					this.OnCustomerNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastSyncDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastSyncDate
		{
			get
			{
				return this._LastSyncDate;
			}
			set
			{
				if ((this._LastSyncDate != value))
				{
					this.OnLastSyncDateChanging(value);
					this.SendPropertyChanging();
					this._LastSyncDate = value;
					this.SendPropertyChanged("LastSyncDate");
					this.OnLastSyncDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Postcode", DbType="NVarChar(MAX)")]
		public string Postcode
		{
			get
			{
				return this._Postcode;
			}
			set
			{
				if ((this._Postcode != value))
				{
					this.OnPostcodeChanging(value);
					this.SendPropertyChanging();
					this._Postcode = value;
					this.SendPropertyChanged("Postcode");
					this.OnPostcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Float")]
		public System.Nullable<double> Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Float")]
		public System.Nullable<double> Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsBarPlusData", DbType="Bit")]
		public System.Nullable<bool> IsBarPlusData
		{
			get
			{
				return this._IsBarPlusData;
			}
			set
			{
				if ((this._IsBarPlusData != value))
				{
					this.OnIsBarPlusDataChanging(value);
					this.SendPropertyChanging();
					this._IsBarPlusData = value;
					this.SendPropertyChanged("IsBarPlusData");
					this.OnIsBarPlusDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RepId", DbType="VarChar(50)")]
		public string RepId
		{
			get
			{
				return this._RepId;
			}
			set
			{
				if ((this._RepId != value))
				{
					this.OnRepIdChanging(value);
					this.SendPropertyChanging();
					this._RepId = value;
					this.SendPropertyChanged("RepId");
					this.OnRepIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RepName", DbType="NVarChar(500)")]
		public string RepName
		{
			get
			{
				return this._RepName;
			}
			set
			{
				if ((this._RepName != value))
				{
					this.OnRepNameChanging(value);
					this.SendPropertyChanging();
					this._RepName = value;
					this.SendPropertyChanged("RepName");
					this.OnRepNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RepNotified", DbType="Bit")]
		public System.Nullable<bool> RepNotified
		{
			get
			{
				return this._RepNotified;
			}
			set
			{
				if ((this._RepNotified != value))
				{
					this.OnRepNotifiedChanging(value);
					this.SendPropertyChanging();
					this._RepNotified = value;
					this.SendPropertyChanged("RepNotified");
					this.OnRepNotifiedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591