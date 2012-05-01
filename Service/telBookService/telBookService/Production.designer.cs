﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBA.Baas
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="telBookBase")]
	public partial class ProductionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertContact(Contact instance);
    partial void UpdateContact(Contact instance);
    partial void DeleteContact(Contact instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertJagatudContact(JagatudContact instance);
    partial void UpdateJagatudContact(JagatudContact instance);
    partial void DeleteJagatudContact(JagatudContact instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    #endregion
		
		public ProductionDataContext() : 
				base(global::telBookService.Properties.Settings.Default.telBookBaseConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public ProductionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Contact> Contacts
		{
			get
			{
				return this.GetTable<Contact>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<JagatudContact> JagatudContacts
		{
			get
			{
				return this.GetTable<JagatudContact>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contact")]
	public partial class Contact : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Eesnimi;
		
		private string _Perenimi;
		
		private string _Telefon;
		
		private string _E_mail;
		
		private string _Skype;
		
		private string _Aadress;
		
		private System.DateTime _Loodud;
		
		private System.Nullable<System.DateTime> _Muudetud;
		
		private System.Nullable<System.DateTime> _Kustutatud;
		
		private int _User_fk;
		
		private EntitySet<JagatudContact> _JagatudContacts;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEesnimiChanging(string value);
    partial void OnEesnimiChanged();
    partial void OnPerenimiChanging(string value);
    partial void OnPerenimiChanged();
    partial void OnTelefonChanging(string value);
    partial void OnTelefonChanged();
    partial void OnE_mailChanging(string value);
    partial void OnE_mailChanged();
    partial void OnSkypeChanging(string value);
    partial void OnSkypeChanged();
    partial void OnAadressChanging(string value);
    partial void OnAadressChanged();
    partial void OnLoodudChanging(System.DateTime value);
    partial void OnLoodudChanged();
    partial void OnMuudetudChanging(System.Nullable<System.DateTime> value);
    partial void OnMuudetudChanged();
    partial void OnKustutatudChanging(System.Nullable<System.DateTime> value);
    partial void OnKustutatudChanged();
    partial void OnUser_fkChanging(int value);
    partial void OnUser_fkChanged();
    #endregion
		
		public Contact()
		{
			this._JagatudContacts = new EntitySet<JagatudContact>(new Action<JagatudContact>(this.attach_JagatudContacts), new Action<JagatudContact>(this.detach_JagatudContacts));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Eesnimi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Eesnimi
		{
			get
			{
				return this._Eesnimi;
			}
			set
			{
				if ((this._Eesnimi != value))
				{
					this.OnEesnimiChanging(value);
					this.SendPropertyChanging();
					this._Eesnimi = value;
					this.SendPropertyChanged("Eesnimi");
					this.OnEesnimiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Perenimi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Perenimi
		{
			get
			{
				return this._Perenimi;
			}
			set
			{
				if ((this._Perenimi != value))
				{
					this.OnPerenimiChanging(value);
					this.SendPropertyChanging();
					this._Perenimi = value;
					this.SendPropertyChanged("Perenimi");
					this.OnPerenimiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefon", DbType="NVarChar(50)")]
		public string Telefon
		{
			get
			{
				return this._Telefon;
			}
			set
			{
				if ((this._Telefon != value))
				{
					this.OnTelefonChanging(value);
					this.SendPropertyChanging();
					this._Telefon = value;
					this.SendPropertyChanged("Telefon");
					this.OnTelefonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[E-mail]", Storage="_E_mail", DbType="NVarChar(50)")]
		public string E_mail
		{
			get
			{
				return this._E_mail;
			}
			set
			{
				if ((this._E_mail != value))
				{
					this.OnE_mailChanging(value);
					this.SendPropertyChanging();
					this._E_mail = value;
					this.SendPropertyChanged("E_mail");
					this.OnE_mailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Skype", DbType="NVarChar(50)")]
		public string Skype
		{
			get
			{
				return this._Skype;
			}
			set
			{
				if ((this._Skype != value))
				{
					this.OnSkypeChanging(value);
					this.SendPropertyChanging();
					this._Skype = value;
					this.SendPropertyChanged("Skype");
					this.OnSkypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Aadress", DbType="NVarChar(50)")]
		public string Aadress
		{
			get
			{
				return this._Aadress;
			}
			set
			{
				if ((this._Aadress != value))
				{
					this.OnAadressChanging(value);
					this.SendPropertyChanging();
					this._Aadress = value;
					this.SendPropertyChanged("Aadress");
					this.OnAadressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Loodud", DbType="SmallDateTime NOT NULL")]
		public System.DateTime Loodud
		{
			get
			{
				return this._Loodud;
			}
			set
			{
				if ((this._Loodud != value))
				{
					this.OnLoodudChanging(value);
					this.SendPropertyChanging();
					this._Loodud = value;
					this.SendPropertyChanged("Loodud");
					this.OnLoodudChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Muudetud", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Muudetud
		{
			get
			{
				return this._Muudetud;
			}
			set
			{
				if ((this._Muudetud != value))
				{
					this.OnMuudetudChanging(value);
					this.SendPropertyChanging();
					this._Muudetud = value;
					this.SendPropertyChanged("Muudetud");
					this.OnMuudetudChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kustutatud", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Kustutatud
		{
			get
			{
				return this._Kustutatud;
			}
			set
			{
				if ((this._Kustutatud != value))
				{
					this.OnKustutatudChanging(value);
					this.SendPropertyChanging();
					this._Kustutatud = value;
					this.SendPropertyChanged("Kustutatud");
					this.OnKustutatudChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_fk", DbType="Int NOT NULL")]
		public int User_fk
		{
			get
			{
				return this._User_fk;
			}
			set
			{
				if ((this._User_fk != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_fkChanging(value);
					this.SendPropertyChanging();
					this._User_fk = value;
					this.SendPropertyChanged("User_fk");
					this.OnUser_fkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Contact_JagatudContact", Storage="_JagatudContacts", ThisKey="ID", OtherKey="ContactID")]
		public EntitySet<JagatudContact> JagatudContacts
		{
			get
			{
				return this._JagatudContacts;
			}
			set
			{
				this._JagatudContacts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Contact", Storage="_User", ThisKey="User_fk", OtherKey="ID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Contacts.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Contacts.Add(this);
						this._User_fk = value.ID;
					}
					else
					{
						this._User_fk = default(int);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_JagatudContacts(JagatudContact entity)
		{
			this.SendPropertyChanging();
			entity.Contact = this;
		}
		
		private void detach_JagatudContacts(JagatudContact entity)
		{
			this.SendPropertyChanging();
			entity.Contact = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Username;
		
		private string _Password;
		
		private string _E_mail;
		
		private System.DateTime _Loodud;
		
		private System.Nullable<System.DateTime> _Muudetud;
		
		private System.Nullable<System.DateTime> _Kustutatud;
		
		private int _Role_fk;
		
		private EntitySet<Contact> _Contacts;
		
		private EntitySet<JagatudContact> _JagatudContacts;
		
		private EntityRef<Role> _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnE_mailChanging(string value);
    partial void OnE_mailChanged();
    partial void OnLoodudChanging(System.DateTime value);
    partial void OnLoodudChanged();
    partial void OnMuudetudChanging(System.Nullable<System.DateTime> value);
    partial void OnMuudetudChanged();
    partial void OnKustutatudChanging(System.Nullable<System.DateTime> value);
    partial void OnKustutatudChanged();
    partial void OnRole_fkChanging(int value);
    partial void OnRole_fkChanged();
    #endregion
		
		public User()
		{
			this._Contacts = new EntitySet<Contact>(new Action<Contact>(this.attach_Contacts), new Action<Contact>(this.detach_Contacts));
			this._JagatudContacts = new EntitySet<JagatudContact>(new Action<JagatudContact>(this.attach_JagatudContacts), new Action<JagatudContact>(this.detach_JagatudContacts));
			this._Role = default(EntityRef<Role>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[E-mail]", Storage="_E_mail", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string E_mail
		{
			get
			{
				return this._E_mail;
			}
			set
			{
				if ((this._E_mail != value))
				{
					this.OnE_mailChanging(value);
					this.SendPropertyChanging();
					this._E_mail = value;
					this.SendPropertyChanged("E_mail");
					this.OnE_mailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Loodud", DbType="SmallDateTime NOT NULL")]
		public System.DateTime Loodud
		{
			get
			{
				return this._Loodud;
			}
			set
			{
				if ((this._Loodud != value))
				{
					this.OnLoodudChanging(value);
					this.SendPropertyChanging();
					this._Loodud = value;
					this.SendPropertyChanged("Loodud");
					this.OnLoodudChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Muudetud", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Muudetud
		{
			get
			{
				return this._Muudetud;
			}
			set
			{
				if ((this._Muudetud != value))
				{
					this.OnMuudetudChanging(value);
					this.SendPropertyChanging();
					this._Muudetud = value;
					this.SendPropertyChanged("Muudetud");
					this.OnMuudetudChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kustutatud", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Kustutatud
		{
			get
			{
				return this._Kustutatud;
			}
			set
			{
				if ((this._Kustutatud != value))
				{
					this.OnKustutatudChanging(value);
					this.SendPropertyChanging();
					this._Kustutatud = value;
					this.SendPropertyChanged("Kustutatud");
					this.OnKustutatudChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role_fk", DbType="Int NOT NULL")]
		public int Role_fk
		{
			get
			{
				return this._Role_fk;
			}
			set
			{
				if ((this._Role_fk != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRole_fkChanging(value);
					this.SendPropertyChanging();
					this._Role_fk = value;
					this.SendPropertyChanged("Role_fk");
					this.OnRole_fkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Contact", Storage="_Contacts", ThisKey="ID", OtherKey="User_fk")]
		public EntitySet<Contact> Contacts
		{
			get
			{
				return this._Contacts;
			}
			set
			{
				this._Contacts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_JagatudContact", Storage="_JagatudContacts", ThisKey="ID", OtherKey="UserID")]
		public EntitySet<JagatudContact> JagatudContacts
		{
			get
			{
				return this._JagatudContacts;
			}
			set
			{
				this._JagatudContacts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Role", ThisKey="Role_fk", OtherKey="ID", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._Role_fk = value.ID;
					}
					else
					{
						this._Role_fk = default(int);
					}
					this.SendPropertyChanged("Role");
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
		
		private void attach_Contacts(Contact entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Contacts(Contact entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_JagatudContacts(JagatudContact entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_JagatudContacts(JagatudContact entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.JagatudContact")]
	public partial class JagatudContact : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _ContactID;
		
		private int _UserID;
		
		private System.DateTime _AlgusKP;
		
		private System.Nullable<System.DateTime> _LoppKP;
		
		private EntityRef<Contact> _Contact;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnContactIDChanging(int value);
    partial void OnContactIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnAlgusKPChanging(System.DateTime value);
    partial void OnAlgusKPChanged();
    partial void OnLoppKPChanging(System.Nullable<System.DateTime> value);
    partial void OnLoppKPChanged();
    #endregion
		
		public JagatudContact()
		{
			this._Contact = default(EntityRef<Contact>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactID", DbType="Int NOT NULL")]
		public int ContactID
		{
			get
			{
				return this._ContactID;
			}
			set
			{
				if ((this._ContactID != value))
				{
					if (this._Contact.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnContactIDChanging(value);
					this.SendPropertyChanging();
					this._ContactID = value;
					this.SendPropertyChanged("ContactID");
					this.OnContactIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlgusKP", DbType="SmallDateTime NOT NULL")]
		public System.DateTime AlgusKP
		{
			get
			{
				return this._AlgusKP;
			}
			set
			{
				if ((this._AlgusKP != value))
				{
					this.OnAlgusKPChanging(value);
					this.SendPropertyChanging();
					this._AlgusKP = value;
					this.SendPropertyChanged("AlgusKP");
					this.OnAlgusKPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoppKP", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> LoppKP
		{
			get
			{
				return this._LoppKP;
			}
			set
			{
				if ((this._LoppKP != value))
				{
					this.OnLoppKPChanging(value);
					this.SendPropertyChanging();
					this._LoppKP = value;
					this.SendPropertyChanged("LoppKP");
					this.OnLoppKPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Contact_JagatudContact", Storage="_Contact", ThisKey="ContactID", OtherKey="ID", IsForeignKey=true)]
		public Contact Contact
		{
			get
			{
				return this._Contact.Entity;
			}
			set
			{
				Contact previousValue = this._Contact.Entity;
				if (((previousValue != value) 
							|| (this._Contact.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Contact.Entity = null;
						previousValue.JagatudContacts.Remove(this);
					}
					this._Contact.Entity = value;
					if ((value != null))
					{
						value.JagatudContacts.Add(this);
						this._ContactID = value.ID;
					}
					else
					{
						this._ContactID = default(int);
					}
					this.SendPropertyChanged("Contact");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_JagatudContact", Storage="_User", ThisKey="UserID", OtherKey="ID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.JagatudContacts.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.JagatudContacts.Add(this);
						this._UserID = value.ID;
					}
					else
					{
						this._UserID = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Role")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Nimetus;
		
		private string _Kirjedus;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNimetusChanging(string value);
    partial void OnNimetusChanged();
    partial void OnKirjedusChanging(string value);
    partial void OnKirjedusChanged();
    #endregion
		
		public Role()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nimetus", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Nimetus
		{
			get
			{
				return this._Nimetus;
			}
			set
			{
				if ((this._Nimetus != value))
				{
					this.OnNimetusChanging(value);
					this.SendPropertyChanging();
					this._Nimetus = value;
					this.SendPropertyChanged("Nimetus");
					this.OnNimetusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kirjedus", DbType="NVarChar(50)")]
		public string Kirjedus
		{
			get
			{
				return this._Kirjedus;
			}
			set
			{
				if ((this._Kirjedus != value))
				{
					this.OnKirjedusChanging(value);
					this.SendPropertyChanging();
					this._Kirjedus = value;
					this.SendPropertyChanged("Kirjedus");
					this.OnKirjedusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Users", ThisKey="ID", OtherKey="Role_fk")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
}
#pragma warning restore 1591