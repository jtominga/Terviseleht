﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.TelBookServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/telBookService")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> KustutatudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LoodudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> MuudetudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SkypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserfkField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Kustutatud {
            get {
                return this.KustutatudField;
            }
            set {
                if ((this.KustutatudField.Equals(value) != true)) {
                    this.KustutatudField = value;
                    this.RaisePropertyChanged("Kustutatud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Loodud {
            get {
                return this.LoodudField;
            }
            set {
                if ((this.LoodudField.Equals(value) != true)) {
                    this.LoodudField = value;
                    this.RaisePropertyChanged("Loodud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Muudetud {
            get {
                return this.MuudetudField;
            }
            set {
                if ((this.MuudetudField.Equals(value) != true)) {
                    this.MuudetudField = value;
                    this.RaisePropertyChanged("Muudetud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Skype {
            get {
                return this.SkypeField;
            }
            set {
                if ((object.ReferenceEquals(this.SkypeField, value) != true)) {
                    this.SkypeField = value;
                    this.RaisePropertyChanged("Skype");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tel {
            get {
                return this.TelField;
            }
            set {
                if ((object.ReferenceEquals(this.TelField, value) != true)) {
                    this.TelField = value;
                    this.RaisePropertyChanged("Tel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Userfk {
            get {
                return this.UserfkField;
            }
            set {
                if ((this.UserfkField.Equals(value) != true)) {
                    this.UserfkField = value;
                    this.RaisePropertyChanged("Userfk");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/telBookService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> KustutatudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LoodudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> MuudetudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.TelBookServiceReference.AuthData authDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Kustutatud {
            get {
                return this.KustutatudField;
            }
            set {
                if ((this.KustutatudField.Equals(value) != true)) {
                    this.KustutatudField = value;
                    this.RaisePropertyChanged("Kustutatud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Loodud {
            get {
                return this.LoodudField;
            }
            set {
                if ((this.LoodudField.Equals(value) != true)) {
                    this.LoodudField = value;
                    this.RaisePropertyChanged("Loodud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Muudetud {
            get {
                return this.MuudetudField;
            }
            set {
                if ((this.MuudetudField.Equals(value) != true)) {
                    this.MuudetudField = value;
                    this.RaisePropertyChanged("Muudetud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Role {
            get {
                return this.RoleField;
            }
            set {
                if ((this.RoleField.Equals(value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.TelBookServiceReference.AuthData authData {
            get {
                return this.authDataField;
            }
            set {
                if ((object.ReferenceEquals(this.authDataField, value) != true)) {
                    this.authDataField = value;
                    this.RaisePropertyChanged("authData");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthData", Namespace="http://schemas.datacontract.org/2004/07/telBookService")]
    [System.SerializableAttribute()]
    public partial class AuthData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsloggedinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordhashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Isloggedin {
            get {
                return this.IsloggedinField;
            }
            set {
                if ((this.IsloggedinField.Equals(value) != true)) {
                    this.IsloggedinField = value;
                    this.RaisePropertyChanged("Isloggedin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Passwordhash {
            get {
                return this.PasswordhashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordhashField, value) != true)) {
                    this.PasswordhashField = value;
                    this.RaisePropertyChanged("Passwordhash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Role {
            get {
                return this.RoleField;
            }
            set {
                if ((this.RoleField.Equals(value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TelBookServiceReference.ItelBookService")]
    public interface ItelBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/getAllContacts", ReplyAction="http://tempuri.org/ItelBookService/getAllContactsResponse")]
        Client.TelBookServiceReference.Contact[] getAllContacts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/deleteContactById", ReplyAction="http://tempuri.org/ItelBookService/deleteContactByIdResponse")]
        void deleteContactById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/saveContact", ReplyAction="http://tempuri.org/ItelBookService/saveContactResponse")]
        void saveContact(Client.TelBookServiceReference.Contact cont);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/saveUser", ReplyAction="http://tempuri.org/ItelBookService/saveUserResponse")]
        void saveUser(Client.TelBookServiceReference.User usr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/login", ReplyAction="http://tempuri.org/ItelBookService/loginResponse")]
        Client.TelBookServiceReference.User login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/getContactsByUser", ReplyAction="http://tempuri.org/ItelBookService/getContactsByUserResponse")]
        Client.TelBookServiceReference.Contact[] getContactsByUser(Client.TelBookServiceReference.User usr, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/getContactById", ReplyAction="http://tempuri.org/ItelBookService/getContactByIdResponse")]
        Client.TelBookServiceReference.Contact getContactById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/getContactByName", ReplyAction="http://tempuri.org/ItelBookService/getContactByNameResponse")]
        Client.TelBookServiceReference.Contact[] getContactByName(string nimi, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/getContactBytel", ReplyAction="http://tempuri.org/ItelBookService/getContactBytelResponse")]
        Client.TelBookServiceReference.Contact[] getContactBytel(string tel, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/getContactByEmail", ReplyAction="http://tempuri.org/ItelBookService/getContactByEmailResponse")]
        Client.TelBookServiceReference.Contact[] getContactByEmail(string email, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/getContactBySkype", ReplyAction="http://tempuri.org/ItelBookService/getContactBySkypeResponse")]
        Client.TelBookServiceReference.Contact[] getContactBySkype(string skype, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItelBookService/getUserByUserName", ReplyAction="http://tempuri.org/ItelBookService/getUserByUserNameResponse")]
        Client.TelBookServiceReference.User getUserByUserName(string nimi);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ItelBookServiceChannel : Client.TelBookServiceReference.ItelBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ItelBookServiceClient : System.ServiceModel.ClientBase<Client.TelBookServiceReference.ItelBookService>, Client.TelBookServiceReference.ItelBookService {
        
        public ItelBookServiceClient() {
        }
        
        public ItelBookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ItelBookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItelBookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItelBookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.TelBookServiceReference.Contact[] getAllContacts() {
            return base.Channel.getAllContacts();
        }
        
        public void deleteContactById(int id) {
            base.Channel.deleteContactById(id);
        }
        
        public void saveContact(Client.TelBookServiceReference.Contact cont) {
            base.Channel.saveContact(cont);
        }
        
        public void saveUser(Client.TelBookServiceReference.User usr) {
            base.Channel.saveUser(usr);
        }
        
        public Client.TelBookServiceReference.User login(string username, string password) {
            return base.Channel.login(username, password);
        }
        
        public Client.TelBookServiceReference.Contact[] getContactsByUser(Client.TelBookServiceReference.User usr, int count) {
            return base.Channel.getContactsByUser(usr, count);
        }
        
        public Client.TelBookServiceReference.Contact getContactById(int id) {
            return base.Channel.getContactById(id);
        }
        
        public Client.TelBookServiceReference.Contact[] getContactByName(string nimi, int count) {
            return base.Channel.getContactByName(nimi, count);
        }
        
        public Client.TelBookServiceReference.Contact[] getContactBytel(string tel, int count) {
            return base.Channel.getContactBytel(tel, count);
        }
        
        public Client.TelBookServiceReference.Contact[] getContactByEmail(string email, int count) {
            return base.Channel.getContactByEmail(email, count);
        }
        
        public Client.TelBookServiceReference.Contact[] getContactBySkype(string skype, int count) {
            return base.Channel.getContactBySkype(skype, count);
        }
        
        public Client.TelBookServiceReference.User getUserByUserName(string nimi) {
            return base.Channel.getUserByUserName(nimi);
        }
    }
}
