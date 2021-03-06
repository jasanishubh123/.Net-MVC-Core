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

namespace sep_2014
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="library")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertbook(book instance);
    partial void Updatebook(book instance);
    partial void Deletebook(book instance);
    partial void Insertborrower(borrower instance);
    partial void Updateborrower(borrower instance);
    partial void Deleteborrower(borrower instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::sep_2014.Properties.Settings.Default.libraryConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<book> books
		{
			get
			{
				return this.GetTable<book>();
			}
		}
		
		public System.Data.Linq.Table<borrower> borrowers
		{
			get
			{
				return this.GetTable<borrower>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.book")]
	public partial class book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _bookid;
		
		private string _bname;
		
		private System.Nullable<int> _price;
		
		private string _author;
		
		private string _subject;
		
		private EntitySet<borrower> _borrowers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbookidChanging(int value);
    partial void OnbookidChanged();
    partial void OnbnameChanging(string value);
    partial void OnbnameChanged();
    partial void OnpriceChanging(System.Nullable<int> value);
    partial void OnpriceChanged();
    partial void OnauthorChanging(string value);
    partial void OnauthorChanged();
    partial void OnsubjectChanging(string value);
    partial void OnsubjectChanged();
    #endregion
		
		public book()
		{
			this._borrowers = new EntitySet<borrower>(new Action<borrower>(this.attach_borrowers), new Action<borrower>(this.detach_borrowers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int bookid
		{
			get
			{
				return this._bookid;
			}
			set
			{
				if ((this._bookid != value))
				{
					this.OnbookidChanging(value);
					this.SendPropertyChanging();
					this._bookid = value;
					this.SendPropertyChanged("bookid");
					this.OnbookidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bname", DbType="VarChar(50)")]
		public string bname
		{
			get
			{
				return this._bname;
			}
			set
			{
				if ((this._bname != value))
				{
					this.OnbnameChanging(value);
					this.SendPropertyChanging();
					this._bname = value;
					this.SendPropertyChanged("bname");
					this.OnbnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int")]
		public System.Nullable<int> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author", DbType="VarChar(50)")]
		public string author
		{
			get
			{
				return this._author;
			}
			set
			{
				if ((this._author != value))
				{
					this.OnauthorChanging(value);
					this.SendPropertyChanging();
					this._author = value;
					this.SendPropertyChanged("author");
					this.OnauthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subject", DbType="VarChar(50)")]
		public string subject
		{
			get
			{
				return this._subject;
			}
			set
			{
				if ((this._subject != value))
				{
					this.OnsubjectChanging(value);
					this.SendPropertyChanging();
					this._subject = value;
					this.SendPropertyChanged("subject");
					this.OnsubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="book_borrower", Storage="_borrowers", ThisKey="bookid", OtherKey="bookid")]
		public EntitySet<borrower> borrowers
		{
			get
			{
				return this._borrowers;
			}
			set
			{
				this._borrowers.Assign(value);
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
		
		private void attach_borrowers(borrower entity)
		{
			this.SendPropertyChanging();
			entity.book = this;
		}
		
		private void detach_borrowers(borrower entity)
		{
			this.SendPropertyChanging();
			entity.book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.borrower")]
	public partial class borrower : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _boid;
		
		private string _boname;
		
		private string _address;
		
		private string _phoneno;
		
		private System.Nullable<int> _bookid;
		
		private EntityRef<book> _book;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnboidChanging(int value);
    partial void OnboidChanged();
    partial void OnbonameChanging(string value);
    partial void OnbonameChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnphonenoChanging(string value);
    partial void OnphonenoChanged();
    partial void OnbookidChanging(System.Nullable<int> value);
    partial void OnbookidChanged();
    #endregion
		
		public borrower()
		{
			this._book = default(EntityRef<book>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_boid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int boid
		{
			get
			{
				return this._boid;
			}
			set
			{
				if ((this._boid != value))
				{
					this.OnboidChanging(value);
					this.SendPropertyChanging();
					this._boid = value;
					this.SendPropertyChanged("boid");
					this.OnboidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_boname", DbType="VarChar(50)")]
		public string boname
		{
			get
			{
				return this._boname;
			}
			set
			{
				if ((this._boname != value))
				{
					this.OnbonameChanging(value);
					this.SendPropertyChanging();
					this._boname = value;
					this.SendPropertyChanged("boname");
					this.OnbonameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(50)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phoneno", DbType="VarChar(50)")]
		public string phoneno
		{
			get
			{
				return this._phoneno;
			}
			set
			{
				if ((this._phoneno != value))
				{
					this.OnphonenoChanging(value);
					this.SendPropertyChanging();
					this._phoneno = value;
					this.SendPropertyChanged("phoneno");
					this.OnphonenoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookid", DbType="Int")]
		public System.Nullable<int> bookid
		{
			get
			{
				return this._bookid;
			}
			set
			{
				if ((this._bookid != value))
				{
					if (this._book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnbookidChanging(value);
					this.SendPropertyChanging();
					this._bookid = value;
					this.SendPropertyChanged("bookid");
					this.OnbookidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="book_borrower", Storage="_book", ThisKey="bookid", OtherKey="bookid", IsForeignKey=true)]
		public book book
		{
			get
			{
				return this._book.Entity;
			}
			set
			{
				book previousValue = this._book.Entity;
				if (((previousValue != value) 
							|| (this._book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._book.Entity = null;
						previousValue.borrowers.Remove(this);
					}
					this._book.Entity = value;
					if ((value != null))
					{
						value.borrowers.Add(this);
						this._bookid = value.bookid;
					}
					else
					{
						this._bookid = default(Nullable<int>);
					}
					this.SendPropertyChanged("book");
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
