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

namespace DhavalSir_TASK.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Products")]
	public partial class ProductsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomerTB(CustomerTB instance);
    partial void UpdateCustomerTB(CustomerTB instance);
    partial void DeleteCustomerTB(CustomerTB instance);
    partial void InsertOrderDetailTB(OrderDetailTB instance);
    partial void UpdateOrderDetailTB(OrderDetailTB instance);
    partial void DeleteOrderDetailTB(OrderDetailTB instance);
    partial void InsertOrderTB(OrderTB instance);
    partial void UpdateOrderTB(OrderTB instance);
    partial void DeleteOrderTB(OrderTB instance);
    partial void InsertProductsTB(ProductsTB instance);
    partial void UpdateProductsTB(ProductsTB instance);
    partial void DeleteProductsTB(ProductsTB instance);
    #endregion
		
		public ProductsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CustomerTB> CustomerTBs
		{
			get
			{
				return this.GetTable<CustomerTB>();
			}
		}
		
		public System.Data.Linq.Table<OrderDetailTB> OrderDetailTBs
		{
			get
			{
				return this.GetTable<OrderDetailTB>();
			}
		}
		
		public System.Data.Linq.Table<OrderTB> OrderTBs
		{
			get
			{
				return this.GetTable<OrderTB>();
			}
		}
		
		public System.Data.Linq.Table<ProductsTB> ProductsTBs
		{
			get
			{
				return this.GetTable<ProductsTB>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerTB")]
	public partial class CustomerTB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerId;
		
		private string _CustomerName;
		
		private System.Nullable<int> _Age;
		
		private string _Email;
		
		private string _Gender;
		
		private EntitySet<OrderTB> _OrderTBs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIdChanging(int value);
    partial void OnCustomerIdChanged();
    partial void OnCustomerNameChanging(string value);
    partial void OnCustomerNameChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    #endregion
		
		public CustomerTB()
		{
			this._OrderTBs = new EntitySet<OrderTB>(new Action<OrderTB>(this.attach_OrderTBs), new Action<OrderTB>(this.detach_OrderTBs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="VarChar(50)")]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this.OnCustomerNameChanging(value);
					this.SendPropertyChanging();
					this._CustomerName = value;
					this.SendPropertyChanged("CustomerName");
					this.OnCustomerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerTB_OrderTB", Storage="_OrderTBs", ThisKey="CustomerId", OtherKey="CustomerId")]
		public EntitySet<OrderTB> OrderTBs
		{
			get
			{
				return this._OrderTBs;
			}
			set
			{
				this._OrderTBs.Assign(value);
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
		
		private void attach_OrderTBs(OrderTB entity)
		{
			this.SendPropertyChanging();
			entity.CustomerTB = this;
		}
		
		private void detach_OrderTBs(OrderTB entity)
		{
			this.SendPropertyChanging();
			entity.CustomerTB = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderDetailTB")]
	public partial class OrderDetailTB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderDetailId;
		
		private System.Nullable<int> _OrderId;
		
		private System.Nullable<int> _ProductId;
		
		private System.Nullable<decimal> _Rate;
		
		private System.Nullable<int> _Qty;
		
		private EntityRef<OrderTB> _OrderTB;
		
		private EntityRef<ProductsTB> _ProductsTB;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderDetailIdChanging(int value);
    partial void OnOrderDetailIdChanged();
    partial void OnOrderIdChanging(System.Nullable<int> value);
    partial void OnOrderIdChanged();
    partial void OnProductIdChanging(System.Nullable<int> value);
    partial void OnProductIdChanged();
    partial void OnRateChanging(System.Nullable<decimal> value);
    partial void OnRateChanged();
    partial void OnQtyChanging(System.Nullable<int> value);
    partial void OnQtyChanged();
    #endregion
		
		public OrderDetailTB()
		{
			this._OrderTB = default(EntityRef<OrderTB>);
			this._ProductsTB = default(EntityRef<ProductsTB>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDetailId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderDetailId
		{
			get
			{
				return this._OrderDetailId;
			}
			set
			{
				if ((this._OrderDetailId != value))
				{
					this.OnOrderDetailIdChanging(value);
					this.SendPropertyChanging();
					this._OrderDetailId = value;
					this.SendPropertyChanged("OrderDetailId");
					this.OnOrderDetailIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int")]
		public System.Nullable<int> OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					if (this._OrderTB.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int")]
		public System.Nullable<int> ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._ProductsTB.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rate", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Rate
		{
			get
			{
				return this._Rate;
			}
			set
			{
				if ((this._Rate != value))
				{
					this.OnRateChanging(value);
					this.SendPropertyChanging();
					this._Rate = value;
					this.SendPropertyChanged("Rate");
					this.OnRateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qty", DbType="Int")]
		public System.Nullable<int> Qty
		{
			get
			{
				return this._Qty;
			}
			set
			{
				if ((this._Qty != value))
				{
					this.OnQtyChanging(value);
					this.SendPropertyChanging();
					this._Qty = value;
					this.SendPropertyChanged("Qty");
					this.OnQtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OrderTB_OrderDetailTB", Storage="_OrderTB", ThisKey="OrderId", OtherKey="OrderId", IsForeignKey=true)]
		public OrderTB OrderTB
		{
			get
			{
				return this._OrderTB.Entity;
			}
			set
			{
				OrderTB previousValue = this._OrderTB.Entity;
				if (((previousValue != value) 
							|| (this._OrderTB.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._OrderTB.Entity = null;
						previousValue.OrderDetailTBs.Remove(this);
					}
					this._OrderTB.Entity = value;
					if ((value != null))
					{
						value.OrderDetailTBs.Add(this);
						this._OrderId = value.OrderId;
					}
					else
					{
						this._OrderId = default(Nullable<int>);
					}
					this.SendPropertyChanged("OrderTB");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ProductsTB_OrderDetailTB", Storage="_ProductsTB", ThisKey="ProductId", OtherKey="ProductId", IsForeignKey=true)]
		public ProductsTB ProductsTB
		{
			get
			{
				return this._ProductsTB.Entity;
			}
			set
			{
				ProductsTB previousValue = this._ProductsTB.Entity;
				if (((previousValue != value) 
							|| (this._ProductsTB.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ProductsTB.Entity = null;
						previousValue.OrderDetailTBs.Remove(this);
					}
					this._ProductsTB.Entity = value;
					if ((value != null))
					{
						value.OrderDetailTBs.Add(this);
						this._ProductId = value.ProductId;
					}
					else
					{
						this._ProductId = default(Nullable<int>);
					}
					this.SendPropertyChanged("ProductsTB");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderTB")]
	public partial class OrderTB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderId;
		
		private System.Nullable<int> _CustomerId;
		
		private System.Nullable<System.DateTime> _Date;
		
		private System.Nullable<decimal> _TotalAmount;
		
		private EntitySet<OrderDetailTB> _OrderDetailTBs;
		
		private EntityRef<CustomerTB> _CustomerTB;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnCustomerIdChanging(System.Nullable<int> value);
    partial void OnCustomerIdChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnTotalAmountChanging(System.Nullable<decimal> value);
    partial void OnTotalAmountChanged();
    #endregion
		
		public OrderTB()
		{
			this._OrderDetailTBs = new EntitySet<OrderDetailTB>(new Action<OrderDetailTB>(this.attach_OrderDetailTBs), new Action<OrderDetailTB>(this.detach_OrderDetailTBs));
			this._CustomerTB = default(EntityRef<CustomerTB>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="Int")]
		public System.Nullable<int> CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._CustomerTB.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalAmount", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> TotalAmount
		{
			get
			{
				return this._TotalAmount;
			}
			set
			{
				if ((this._TotalAmount != value))
				{
					this.OnTotalAmountChanging(value);
					this.SendPropertyChanging();
					this._TotalAmount = value;
					this.SendPropertyChanged("TotalAmount");
					this.OnTotalAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OrderTB_OrderDetailTB", Storage="_OrderDetailTBs", ThisKey="OrderId", OtherKey="OrderId")]
		public EntitySet<OrderDetailTB> OrderDetailTBs
		{
			get
			{
				return this._OrderDetailTBs;
			}
			set
			{
				this._OrderDetailTBs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerTB_OrderTB", Storage="_CustomerTB", ThisKey="CustomerId", OtherKey="CustomerId", IsForeignKey=true)]
		public CustomerTB CustomerTB
		{
			get
			{
				return this._CustomerTB.Entity;
			}
			set
			{
				CustomerTB previousValue = this._CustomerTB.Entity;
				if (((previousValue != value) 
							|| (this._CustomerTB.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CustomerTB.Entity = null;
						previousValue.OrderTBs.Remove(this);
					}
					this._CustomerTB.Entity = value;
					if ((value != null))
					{
						value.OrderTBs.Add(this);
						this._CustomerId = value.CustomerId;
					}
					else
					{
						this._CustomerId = default(Nullable<int>);
					}
					this.SendPropertyChanged("CustomerTB");
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
		
		private void attach_OrderDetailTBs(OrderDetailTB entity)
		{
			this.SendPropertyChanging();
			entity.OrderTB = this;
		}
		
		private void detach_OrderDetailTBs(OrderDetailTB entity)
		{
			this.SendPropertyChanging();
			entity.OrderTB = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductsTB")]
	public partial class ProductsTB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductId;
		
		private string _ProductName;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<int> _Quantity;
		
		private string _Description;
		
		private EntitySet<OrderDetailTB> _OrderDetailTBs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public ProductsTB()
		{
			this._OrderDetailTBs = new EntitySet<OrderDetailTB>(new Action<OrderDetailTB>(this.attach_OrderDetailTBs), new Action<OrderDetailTB>(this.detach_OrderDetailTBs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(50)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ProductsTB_OrderDetailTB", Storage="_OrderDetailTBs", ThisKey="ProductId", OtherKey="ProductId")]
		public EntitySet<OrderDetailTB> OrderDetailTBs
		{
			get
			{
				return this._OrderDetailTBs;
			}
			set
			{
				this._OrderDetailTBs.Assign(value);
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
		
		private void attach_OrderDetailTBs(OrderDetailTB entity)
		{
			this.SendPropertyChanging();
			entity.ProductsTB = this;
		}
		
		private void detach_OrderDetailTBs(OrderDetailTB entity)
		{
			this.SendPropertyChanging();
			entity.ProductsTB = null;
		}
	}
}
#pragma warning restore 1591