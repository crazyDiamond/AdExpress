﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdExpress.AdExpressWcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ad", Namespace="http://schemas.datacontract.org/2004/07/AdExpressServices.Models")]
    [System.SerializableAttribute()]
    public partial class Ad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WidthField;
        
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
        public int Height {
            get {
                return this.HeightField;
            }
            set {
                if ((this.HeightField.Equals(value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Version {
            get {
                return this.VersionField;
            }
            set {
                if ((object.ReferenceEquals(this.VersionField, value) != true)) {
                    this.VersionField = value;
                    this.RaisePropertyChanged("Version");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Width {
            get {
                return this.WidthField;
            }
            set {
                if ((this.WidthField.Equals(value) != true)) {
                    this.WidthField = value;
                    this.RaisePropertyChanged("Width");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Newspaper", Namespace="http://schemas.datacontract.org/2004/07/AdExpressServices.Models")]
    [System.SerializableAttribute()]
    public partial class Newspaper : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Association", Namespace="http://schemas.datacontract.org/2004/07/AdExpressServices.Models")]
    [System.SerializableAttribute()]
    public partial class Association : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdExpress.AdExpressWcfService.Ad AdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AdIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdExpress.AdExpressWcfService.Newspaper NewspaperField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NewspaperIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateTimeField;
        
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
        public AdExpress.AdExpressWcfService.Ad Ad {
            get {
                return this.AdField;
            }
            set {
                if ((object.ReferenceEquals(this.AdField, value) != true)) {
                    this.AdField = value;
                    this.RaisePropertyChanged("Ad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AdId {
            get {
                return this.AdIdField;
            }
            set {
                if ((this.AdIdField.Equals(value) != true)) {
                    this.AdIdField = value;
                    this.RaisePropertyChanged("AdId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDateTime {
            get {
                return this.EndDateTimeField;
            }
            set {
                if ((this.EndDateTimeField.Equals(value) != true)) {
                    this.EndDateTimeField = value;
                    this.RaisePropertyChanged("EndDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AdExpress.AdExpressWcfService.Newspaper Newspaper {
            get {
                return this.NewspaperField;
            }
            set {
                if ((object.ReferenceEquals(this.NewspaperField, value) != true)) {
                    this.NewspaperField = value;
                    this.RaisePropertyChanged("Newspaper");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NewspaperId {
            get {
                return this.NewspaperIdField;
            }
            set {
                if ((this.NewspaperIdField.Equals(value) != true)) {
                    this.NewspaperIdField = value;
                    this.RaisePropertyChanged("NewspaperId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDateTime {
            get {
                return this.StartDateTimeField;
            }
            set {
                if ((this.StartDateTimeField.Equals(value) != true)) {
                    this.StartDateTimeField = value;
                    this.RaisePropertyChanged("StartDateTime");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdExpressWcfService.IAdExpressWcfService")]
    public interface IAdExpressWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/AddAd", ReplyAction="http://tempuri.org/IAdExpressWcfService/AddAdResponse")]
        AdExpress.AdExpressWcfService.Ad AddAd(string title, string version);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/AddAd", ReplyAction="http://tempuri.org/IAdExpressWcfService/AddAdResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Ad> AddAdAsync(string title, string version);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/GetAllAdsList", ReplyAction="http://tempuri.org/IAdExpressWcfService/GetAllAdsListResponse")]
        AdExpress.AdExpressWcfService.Ad[] GetAllAdsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/GetAllAdsList", ReplyAction="http://tempuri.org/IAdExpressWcfService/GetAllAdsListResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Ad[]> GetAllAdsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/FindAd", ReplyAction="http://tempuri.org/IAdExpressWcfService/FindAdResponse")]
        AdExpress.AdExpressWcfService.Ad FindAd(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/FindAd", ReplyAction="http://tempuri.org/IAdExpressWcfService/FindAdResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Ad> FindAdAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/SaveAd", ReplyAction="http://tempuri.org/IAdExpressWcfService/SaveAdResponse")]
        AdExpress.AdExpressWcfService.Ad SaveAd(AdExpress.AdExpressWcfService.Ad ad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/SaveAd", ReplyAction="http://tempuri.org/IAdExpressWcfService/SaveAdResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Ad> SaveAdAsync(AdExpress.AdExpressWcfService.Ad ad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/RemoveAd", ReplyAction="http://tempuri.org/IAdExpressWcfService/RemoveAdResponse")]
        void RemoveAd(AdExpress.AdExpressWcfService.Ad ad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/RemoveAd", ReplyAction="http://tempuri.org/IAdExpressWcfService/RemoveAdResponse")]
        System.Threading.Tasks.Task RemoveAdAsync(AdExpress.AdExpressWcfService.Ad ad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/AddNewspaper", ReplyAction="http://tempuri.org/IAdExpressWcfService/AddNewspaperResponse")]
        AdExpress.AdExpressWcfService.Newspaper AddNewspaper(string name, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/AddNewspaper", ReplyAction="http://tempuri.org/IAdExpressWcfService/AddNewspaperResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Newspaper> AddNewspaperAsync(string name, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/GetAllNewspapers", ReplyAction="http://tempuri.org/IAdExpressWcfService/GetAllNewspapersResponse")]
        AdExpress.AdExpressWcfService.Newspaper[] GetAllNewspapers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/GetAllNewspapers", ReplyAction="http://tempuri.org/IAdExpressWcfService/GetAllNewspapersResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Newspaper[]> GetAllNewspapersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/FindNewspaper", ReplyAction="http://tempuri.org/IAdExpressWcfService/FindNewspaperResponse")]
        AdExpress.AdExpressWcfService.Newspaper FindNewspaper(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/FindNewspaper", ReplyAction="http://tempuri.org/IAdExpressWcfService/FindNewspaperResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Newspaper> FindNewspaperAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/SaveNewspaper", ReplyAction="http://tempuri.org/IAdExpressWcfService/SaveNewspaperResponse")]
        AdExpress.AdExpressWcfService.Newspaper SaveNewspaper(AdExpress.AdExpressWcfService.Newspaper newspaper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/SaveNewspaper", ReplyAction="http://tempuri.org/IAdExpressWcfService/SaveNewspaperResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Newspaper> SaveNewspaperAsync(AdExpress.AdExpressWcfService.Newspaper newspaper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/RemoveNewspaper", ReplyAction="http://tempuri.org/IAdExpressWcfService/RemoveNewspaperResponse")]
        void RemoveNewspaper(AdExpress.AdExpressWcfService.Newspaper newspaper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/RemoveNewspaper", ReplyAction="http://tempuri.org/IAdExpressWcfService/RemoveNewspaperResponse")]
        System.Threading.Tasks.Task RemoveNewspaperAsync(AdExpress.AdExpressWcfService.Newspaper newspaper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/AddAssociation", ReplyAction="http://tempuri.org/IAdExpressWcfService/AddAssociationResponse")]
        AdExpress.AdExpressWcfService.Association AddAssociation(System.DateTime startDateTime, System.DateTime endDateTime, int adID, int newspaperID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/AddAssociation", ReplyAction="http://tempuri.org/IAdExpressWcfService/AddAssociationResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Association> AddAssociationAsync(System.DateTime startDateTime, System.DateTime endDateTime, int adID, int newspaperID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/GetAllAssociations", ReplyAction="http://tempuri.org/IAdExpressWcfService/GetAllAssociationsResponse")]
        AdExpress.AdExpressWcfService.Association[] GetAllAssociations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/GetAllAssociations", ReplyAction="http://tempuri.org/IAdExpressWcfService/GetAllAssociationsResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Association[]> GetAllAssociationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/FindAssociation", ReplyAction="http://tempuri.org/IAdExpressWcfService/FindAssociationResponse")]
        AdExpress.AdExpressWcfService.Association FindAssociation(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/FindAssociation", ReplyAction="http://tempuri.org/IAdExpressWcfService/FindAssociationResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Association> FindAssociationAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/SaveAssociation", ReplyAction="http://tempuri.org/IAdExpressWcfService/SaveAssociationResponse")]
        AdExpress.AdExpressWcfService.Association SaveAssociation(AdExpress.AdExpressWcfService.Association association);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/SaveAssociation", ReplyAction="http://tempuri.org/IAdExpressWcfService/SaveAssociationResponse")]
        System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Association> SaveAssociationAsync(AdExpress.AdExpressWcfService.Association association);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/RemoveAssociation", ReplyAction="http://tempuri.org/IAdExpressWcfService/RemoveAssociationResponse")]
        void RemoveAssociation(AdExpress.AdExpressWcfService.Association association);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdExpressWcfService/RemoveAssociation", ReplyAction="http://tempuri.org/IAdExpressWcfService/RemoveAssociationResponse")]
        System.Threading.Tasks.Task RemoveAssociationAsync(AdExpress.AdExpressWcfService.Association association);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdExpressWcfServiceChannel : AdExpress.AdExpressWcfService.IAdExpressWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdExpressWcfServiceClient : System.ServiceModel.ClientBase<AdExpress.AdExpressWcfService.IAdExpressWcfService>, AdExpress.AdExpressWcfService.IAdExpressWcfService {
        
        public AdExpressWcfServiceClient() {
        }
        
        public AdExpressWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdExpressWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdExpressWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdExpressWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AdExpress.AdExpressWcfService.Ad AddAd(string title, string version) {
            return base.Channel.AddAd(title, version);
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Ad> AddAdAsync(string title, string version) {
            return base.Channel.AddAdAsync(title, version);
        }
        
        public AdExpress.AdExpressWcfService.Ad[] GetAllAdsList() {
            return base.Channel.GetAllAdsList();
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Ad[]> GetAllAdsListAsync() {
            return base.Channel.GetAllAdsListAsync();
        }
        
        public AdExpress.AdExpressWcfService.Ad FindAd(System.Nullable<int> id) {
            return base.Channel.FindAd(id);
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Ad> FindAdAsync(System.Nullable<int> id) {
            return base.Channel.FindAdAsync(id);
        }
        
        public AdExpress.AdExpressWcfService.Ad SaveAd(AdExpress.AdExpressWcfService.Ad ad) {
            return base.Channel.SaveAd(ad);
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Ad> SaveAdAsync(AdExpress.AdExpressWcfService.Ad ad) {
            return base.Channel.SaveAdAsync(ad);
        }
        
        public void RemoveAd(AdExpress.AdExpressWcfService.Ad ad) {
            base.Channel.RemoveAd(ad);
        }
        
        public System.Threading.Tasks.Task RemoveAdAsync(AdExpress.AdExpressWcfService.Ad ad) {
            return base.Channel.RemoveAdAsync(ad);
        }
        
        public AdExpress.AdExpressWcfService.Newspaper AddNewspaper(string name, string category) {
            return base.Channel.AddNewspaper(name, category);
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Newspaper> AddNewspaperAsync(string name, string category) {
            return base.Channel.AddNewspaperAsync(name, category);
        }
        
        public AdExpress.AdExpressWcfService.Newspaper[] GetAllNewspapers() {
            return base.Channel.GetAllNewspapers();
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Newspaper[]> GetAllNewspapersAsync() {
            return base.Channel.GetAllNewspapersAsync();
        }
        
        public AdExpress.AdExpressWcfService.Newspaper FindNewspaper(System.Nullable<int> id) {
            return base.Channel.FindNewspaper(id);
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Newspaper> FindNewspaperAsync(System.Nullable<int> id) {
            return base.Channel.FindNewspaperAsync(id);
        }
        
        public AdExpress.AdExpressWcfService.Newspaper SaveNewspaper(AdExpress.AdExpressWcfService.Newspaper newspaper) {
            return base.Channel.SaveNewspaper(newspaper);
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Newspaper> SaveNewspaperAsync(AdExpress.AdExpressWcfService.Newspaper newspaper) {
            return base.Channel.SaveNewspaperAsync(newspaper);
        }
        
        public void RemoveNewspaper(AdExpress.AdExpressWcfService.Newspaper newspaper) {
            base.Channel.RemoveNewspaper(newspaper);
        }
        
        public System.Threading.Tasks.Task RemoveNewspaperAsync(AdExpress.AdExpressWcfService.Newspaper newspaper) {
            return base.Channel.RemoveNewspaperAsync(newspaper);
        }
        
        public AdExpress.AdExpressWcfService.Association AddAssociation(System.DateTime startDateTime, System.DateTime endDateTime, int adID, int newspaperID) {
            return base.Channel.AddAssociation(startDateTime, endDateTime, adID, newspaperID);
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Association> AddAssociationAsync(System.DateTime startDateTime, System.DateTime endDateTime, int adID, int newspaperID) {
            return base.Channel.AddAssociationAsync(startDateTime, endDateTime, adID, newspaperID);
        }
        
        public AdExpress.AdExpressWcfService.Association[] GetAllAssociations() {
            return base.Channel.GetAllAssociations();
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Association[]> GetAllAssociationsAsync() {
            return base.Channel.GetAllAssociationsAsync();
        }
        
        public AdExpress.AdExpressWcfService.Association FindAssociation(System.Nullable<int> id) {
            return base.Channel.FindAssociation(id);
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Association> FindAssociationAsync(System.Nullable<int> id) {
            return base.Channel.FindAssociationAsync(id);
        }
        
        public AdExpress.AdExpressWcfService.Association SaveAssociation(AdExpress.AdExpressWcfService.Association association) {
            return base.Channel.SaveAssociation(association);
        }
        
        public System.Threading.Tasks.Task<AdExpress.AdExpressWcfService.Association> SaveAssociationAsync(AdExpress.AdExpressWcfService.Association association) {
            return base.Channel.SaveAssociationAsync(association);
        }
        
        public void RemoveAssociation(AdExpress.AdExpressWcfService.Association association) {
            base.Channel.RemoveAssociation(association);
        }
        
        public System.Threading.Tasks.Task RemoveAssociationAsync(AdExpress.AdExpressWcfService.Association association) {
            return base.Channel.RemoveAssociationAsync(association);
        }
    }
}
