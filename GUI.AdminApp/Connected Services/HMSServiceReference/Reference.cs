﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.26720.2
// 
namespace GUI.AdminApp.HMSServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="http://schemas.datacontract.org/2004/07/HMS.Models")]
    public partial class Room : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int RoomCapacityAdultsField;
        
        private int RoomCapacityChildsField;
        
        private string RoomCapacityNameField;
        
        private string RoomCategoryBedsField;
        
        private string RoomCategoryDescriptionField;
        
        private string RoomCategoryNameField;
        
        private int RoomCountField;
        
        private int RoomDoorNumberField;
        
        private int RoomIdField;
        
        private double RoomPriceField;
        
        private bool RoomStatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoomCapacityAdults {
            get {
                return this.RoomCapacityAdultsField;
            }
            set {
                if ((this.RoomCapacityAdultsField.Equals(value) != true)) {
                    this.RoomCapacityAdultsField = value;
                    this.RaisePropertyChanged("RoomCapacityAdults");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoomCapacityChilds {
            get {
                return this.RoomCapacityChildsField;
            }
            set {
                if ((this.RoomCapacityChildsField.Equals(value) != true)) {
                    this.RoomCapacityChildsField = value;
                    this.RaisePropertyChanged("RoomCapacityChilds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomCapacityName {
            get {
                return this.RoomCapacityNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomCapacityNameField, value) != true)) {
                    this.RoomCapacityNameField = value;
                    this.RaisePropertyChanged("RoomCapacityName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomCategoryBeds {
            get {
                return this.RoomCategoryBedsField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomCategoryBedsField, value) != true)) {
                    this.RoomCategoryBedsField = value;
                    this.RaisePropertyChanged("RoomCategoryBeds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomCategoryDescription {
            get {
                return this.RoomCategoryDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomCategoryDescriptionField, value) != true)) {
                    this.RoomCategoryDescriptionField = value;
                    this.RaisePropertyChanged("RoomCategoryDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomCategoryName {
            get {
                return this.RoomCategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomCategoryNameField, value) != true)) {
                    this.RoomCategoryNameField = value;
                    this.RaisePropertyChanged("RoomCategoryName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoomCount {
            get {
                return this.RoomCountField;
            }
            set {
                if ((this.RoomCountField.Equals(value) != true)) {
                    this.RoomCountField = value;
                    this.RaisePropertyChanged("RoomCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoomDoorNumber {
            get {
                return this.RoomDoorNumberField;
            }
            set {
                if ((this.RoomDoorNumberField.Equals(value) != true)) {
                    this.RoomDoorNumberField = value;
                    this.RaisePropertyChanged("RoomDoorNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoomId {
            get {
                return this.RoomIdField;
            }
            set {
                if ((this.RoomIdField.Equals(value) != true)) {
                    this.RoomIdField = value;
                    this.RaisePropertyChanged("RoomId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RoomPrice {
            get {
                return this.RoomPriceField;
            }
            set {
                if ((this.RoomPriceField.Equals(value) != true)) {
                    this.RoomPriceField = value;
                    this.RaisePropertyChanged("RoomPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool RoomStatus {
            get {
                return this.RoomStatusField;
            }
            set {
                if ((this.RoomStatusField.Equals(value) != true)) {
                    this.RoomStatusField = value;
                    this.RaisePropertyChanged("RoomStatus");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Booking", Namespace="http://schemas.datacontract.org/2004/07/HMS.Models")]
    public partial class Booking : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.DateTime BookingArrivalDateField;
        
        private int BookingCustomerIdField;
        
        private System.DateTime BookingDateField;
        
        private System.DateTime BookingDepartureDateField;
        
        private int BookingIdField;
        
        private int BookingRoomCategoryIdField;
        
        private int BookingRoomIdField;
        
        private bool BookingStatusField;
        
        private int BookingTotalAdultsField;
        
        private int BookingTotalChildsField;
        
        private float BookingTotalCostField;
        
        private int BookingTotalNightsField;
        
        private int BookingTotalRoomsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BookingArrivalDate {
            get {
                return this.BookingArrivalDateField;
            }
            set {
                if ((this.BookingArrivalDateField.Equals(value) != true)) {
                    this.BookingArrivalDateField = value;
                    this.RaisePropertyChanged("BookingArrivalDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookingCustomerId {
            get {
                return this.BookingCustomerIdField;
            }
            set {
                if ((this.BookingCustomerIdField.Equals(value) != true)) {
                    this.BookingCustomerIdField = value;
                    this.RaisePropertyChanged("BookingCustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BookingDate {
            get {
                return this.BookingDateField;
            }
            set {
                if ((this.BookingDateField.Equals(value) != true)) {
                    this.BookingDateField = value;
                    this.RaisePropertyChanged("BookingDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BookingDepartureDate {
            get {
                return this.BookingDepartureDateField;
            }
            set {
                if ((this.BookingDepartureDateField.Equals(value) != true)) {
                    this.BookingDepartureDateField = value;
                    this.RaisePropertyChanged("BookingDepartureDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookingId {
            get {
                return this.BookingIdField;
            }
            set {
                if ((this.BookingIdField.Equals(value) != true)) {
                    this.BookingIdField = value;
                    this.RaisePropertyChanged("BookingId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookingRoomCategoryId {
            get {
                return this.BookingRoomCategoryIdField;
            }
            set {
                if ((this.BookingRoomCategoryIdField.Equals(value) != true)) {
                    this.BookingRoomCategoryIdField = value;
                    this.RaisePropertyChanged("BookingRoomCategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookingRoomId {
            get {
                return this.BookingRoomIdField;
            }
            set {
                if ((this.BookingRoomIdField.Equals(value) != true)) {
                    this.BookingRoomIdField = value;
                    this.RaisePropertyChanged("BookingRoomId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BookingStatus {
            get {
                return this.BookingStatusField;
            }
            set {
                if ((this.BookingStatusField.Equals(value) != true)) {
                    this.BookingStatusField = value;
                    this.RaisePropertyChanged("BookingStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookingTotalAdults {
            get {
                return this.BookingTotalAdultsField;
            }
            set {
                if ((this.BookingTotalAdultsField.Equals(value) != true)) {
                    this.BookingTotalAdultsField = value;
                    this.RaisePropertyChanged("BookingTotalAdults");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookingTotalChilds {
            get {
                return this.BookingTotalChildsField;
            }
            set {
                if ((this.BookingTotalChildsField.Equals(value) != true)) {
                    this.BookingTotalChildsField = value;
                    this.RaisePropertyChanged("BookingTotalChilds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float BookingTotalCost {
            get {
                return this.BookingTotalCostField;
            }
            set {
                if ((this.BookingTotalCostField.Equals(value) != true)) {
                    this.BookingTotalCostField = value;
                    this.RaisePropertyChanged("BookingTotalCost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookingTotalNights {
            get {
                return this.BookingTotalNightsField;
            }
            set {
                if ((this.BookingTotalNightsField.Equals(value) != true)) {
                    this.BookingTotalNightsField = value;
                    this.RaisePropertyChanged("BookingTotalNights");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookingTotalRooms {
            get {
                return this.BookingTotalRoomsField;
            }
            set {
                if ((this.BookingTotalRoomsField.Equals(value) != true)) {
                    this.BookingTotalRoomsField = value;
                    this.RaisePropertyChanged("BookingTotalRooms");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerDetails", Namespace="http://schemas.datacontract.org/2004/07/HMS.Models")]
    public partial class CustomerDetails : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool CheckedInField;
        
        private int CustomerDetailsIdField;
        
        private int CustomerIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CheckedIn {
            get {
                return this.CheckedInField;
            }
            set {
                if ((this.CheckedInField.Equals(value) != true)) {
                    this.CheckedInField = value;
                    this.RaisePropertyChanged("CheckedIn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerDetailsId {
            get {
                return this.CustomerDetailsIdField;
            }
            set {
                if ((this.CustomerDetailsIdField.Equals(value) != true)) {
                    this.CustomerDetailsIdField = value;
                    this.RaisePropertyChanged("CustomerDetailsId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Hotel", Namespace="http://schemas.datacontract.org/2004/07/HMS.Models")]
    public partial class Hotel : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string HotelDescriptionField;
        
        private int HotelIdField;
        
        private string HotelNameField;
        
        private int HotelTotalFloorsField;
        
        private int HotelTotalRoomsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HotelDescription {
            get {
                return this.HotelDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.HotelDescriptionField, value) != true)) {
                    this.HotelDescriptionField = value;
                    this.RaisePropertyChanged("HotelDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HotelId {
            get {
                return this.HotelIdField;
            }
            set {
                if ((this.HotelIdField.Equals(value) != true)) {
                    this.HotelIdField = value;
                    this.RaisePropertyChanged("HotelId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HotelName {
            get {
                return this.HotelNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HotelNameField, value) != true)) {
                    this.HotelNameField = value;
                    this.RaisePropertyChanged("HotelName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HotelTotalFloors {
            get {
                return this.HotelTotalFloorsField;
            }
            set {
                if ((this.HotelTotalFloorsField.Equals(value) != true)) {
                    this.HotelTotalFloorsField = value;
                    this.RaisePropertyChanged("HotelTotalFloors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HotelTotalRooms {
            get {
                return this.HotelTotalRoomsField;
            }
            set {
                if ((this.HotelTotalRoomsField.Equals(value) != true)) {
                    this.HotelTotalRoomsField = value;
                    this.RaisePropertyChanged("HotelTotalRooms");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/HMS.Models")]
    public partial class Customer : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string CustomerAddressField;
        
        private string CustomerCityField;
        
        private string CustomerCountryField;
        
        private string CustomerEmailField;
        
        private string CustomerFNameField;
        
        private string CustomerGenderField;
        
        private int CustomerIdField;
        
        private string CustomerLNameField;
        
        private string CustomerPhoneNoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerAddress {
            get {
                return this.CustomerAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerAddressField, value) != true)) {
                    this.CustomerAddressField = value;
                    this.RaisePropertyChanged("CustomerAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerCity {
            get {
                return this.CustomerCityField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerCityField, value) != true)) {
                    this.CustomerCityField = value;
                    this.RaisePropertyChanged("CustomerCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerCountry {
            get {
                return this.CustomerCountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerCountryField, value) != true)) {
                    this.CustomerCountryField = value;
                    this.RaisePropertyChanged("CustomerCountry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerEmail {
            get {
                return this.CustomerEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerEmailField, value) != true)) {
                    this.CustomerEmailField = value;
                    this.RaisePropertyChanged("CustomerEmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerFName {
            get {
                return this.CustomerFNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerFNameField, value) != true)) {
                    this.CustomerFNameField = value;
                    this.RaisePropertyChanged("CustomerFName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerGender {
            get {
                return this.CustomerGenderField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerGenderField, value) != true)) {
                    this.CustomerGenderField = value;
                    this.RaisePropertyChanged("CustomerGender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerLName {
            get {
                return this.CustomerLNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerLNameField, value) != true)) {
                    this.CustomerLNameField = value;
                    this.RaisePropertyChanged("CustomerLName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerPhoneNo {
            get {
                return this.CustomerPhoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerPhoneNoField, value) != true)) {
                    this.CustomerPhoneNoField = value;
                    this.RaisePropertyChanged("CustomerPhoneNo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HMSServiceReference.IHMSService")]
    public interface IHMSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRooms", ReplyAction="http://tempuri.org/IHMSService/GetRoomsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<GUI.AdminApp.HMSServiceReference.Room>> GetRoomsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateRoom", ReplyAction="http://tempuri.org/IHMSService/CreateRoomResponse")]
        System.Threading.Tasks.Task CreateRoomAsync(GUI.AdminApp.HMSServiceReference.Room roomObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetBookingStatus", ReplyAction="http://tempuri.org/IHMSService/GetBookingStatusResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<GUI.AdminApp.HMSServiceReference.Booking>> GetBookingStatusAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateBooking", ReplyAction="http://tempuri.org/IHMSService/CreateBookingResponse")]
        System.Threading.Tasks.Task CreateBookingAsync(GUI.AdminApp.HMSServiceReference.Booking bookingObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCustomerDetails", ReplyAction="http://tempuri.org/IHMSService/GetCustomerDetailsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<GUI.AdminApp.HMSServiceReference.CustomerDetails>> GetCustomerDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetHotels", ReplyAction="http://tempuri.org/IHMSService/GetHotelsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<GUI.AdminApp.HMSServiceReference.Hotel>> GetHotelsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateHotel", ReplyAction="http://tempuri.org/IHMSService/CreateHotelResponse")]
        System.Threading.Tasks.Task CreateHotelAsync(GUI.AdminApp.HMSServiceReference.Hotel hotelObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateUser", ReplyAction="http://tempuri.org/IHMSService/CreateUserResponse")]
        System.Threading.Tasks.Task CreateUserAsync(GUI.AdminApp.HMSServiceReference.Customer customerObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/DeleteRoomById", ReplyAction="http://tempuri.org/IHMSService/DeleteRoomByIdResponse")]
        System.Threading.Tasks.Task DeleteRoomByIdAsync(int roomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCustomers", ReplyAction="http://tempuri.org/IHMSService/GetCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<GUI.AdminApp.HMSServiceReference.Customer>> GetCustomersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHMSServiceChannel : GUI.AdminApp.HMSServiceReference.IHMSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HMSServiceClient : System.ServiceModel.ClientBase<GUI.AdminApp.HMSServiceReference.IHMSService>, GUI.AdminApp.HMSServiceReference.IHMSService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public HMSServiceClient() : 
                base(HMSServiceClient.GetDefaultBinding(), HMSServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IHMSService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HMSServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(HMSServiceClient.GetBindingForEndpoint(endpointConfiguration), HMSServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HMSServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(HMSServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HMSServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(HMSServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HMSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<GUI.AdminApp.HMSServiceReference.Room>> GetRoomsAsync() {
            return base.Channel.GetRoomsAsync();
        }
        
        public System.Threading.Tasks.Task CreateRoomAsync(GUI.AdminApp.HMSServiceReference.Room roomObject) {
            return base.Channel.CreateRoomAsync(roomObject);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<GUI.AdminApp.HMSServiceReference.Booking>> GetBookingStatusAsync() {
            return base.Channel.GetBookingStatusAsync();
        }
        
        public System.Threading.Tasks.Task CreateBookingAsync(GUI.AdminApp.HMSServiceReference.Booking bookingObject) {
            return base.Channel.CreateBookingAsync(bookingObject);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<GUI.AdminApp.HMSServiceReference.CustomerDetails>> GetCustomerDetailsAsync() {
            return base.Channel.GetCustomerDetailsAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<GUI.AdminApp.HMSServiceReference.Hotel>> GetHotelsAsync() {
            return base.Channel.GetHotelsAsync();
        }
        
        public System.Threading.Tasks.Task CreateHotelAsync(GUI.AdminApp.HMSServiceReference.Hotel hotelObject) {
            return base.Channel.CreateHotelAsync(hotelObject);
        }
        
        public System.Threading.Tasks.Task CreateUserAsync(GUI.AdminApp.HMSServiceReference.Customer customerObject) {
            return base.Channel.CreateUserAsync(customerObject);
        }
        
        public System.Threading.Tasks.Task DeleteRoomByIdAsync(int roomId) {
            return base.Channel.DeleteRoomByIdAsync(roomId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<GUI.AdminApp.HMSServiceReference.Customer>> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IHMSService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IHMSService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:52028/HMSService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return HMSServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IHMSService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return HMSServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IHMSService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IHMSService,
        }
    }
}