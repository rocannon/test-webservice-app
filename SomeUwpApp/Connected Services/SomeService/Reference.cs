﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.26228.0
// 
namespace SomeUwpApp.SomeService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Setting", Namespace="http://localhost/")]
    public partial class Setting : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string KeyField;
        
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/", ConfigurationName="SomeService.ServiceSoap")]
    public interface ServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/GetSettings", ReplyAction="*")]
        System.Threading.Tasks.Task<SomeUwpApp.SomeService.GetSettingsResponse> GetSettingsAsync(SomeUwpApp.SomeService.GetSettingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/GetSettingsWithoutParams", ReplyAction="*")]
        System.Threading.Tasks.Task<SomeUwpApp.SomeService.GetSettingsWithoutParams1> GetSettings1Async(SomeUwpApp.SomeService.GetSettingsWithoutParams request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSettingsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSettings", Namespace="http://localhost/", Order=0)]
        public SomeUwpApp.SomeService.GetSettingsRequestBody Body;
        
        public GetSettingsRequest() {
        }
        
        public GetSettingsRequest(SomeUwpApp.SomeService.GetSettingsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost/")]
    public partial class GetSettingsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string searchField;
        
        public GetSettingsRequestBody() {
        }
        
        public GetSettingsRequestBody(string searchField) {
            this.searchField = searchField;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSettingsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSettingsResponse", Namespace="http://localhost/", Order=0)]
        public SomeUwpApp.SomeService.GetSettingsResponseBody Body;
        
        public GetSettingsResponse() {
        }
        
        public GetSettingsResponse(SomeUwpApp.SomeService.GetSettingsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost/")]
    public partial class GetSettingsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.ObjectModel.ObservableCollection<SomeUwpApp.SomeService.Setting> GetSettingsResult;
        
        public GetSettingsResponseBody() {
        }
        
        public GetSettingsResponseBody(System.Collections.ObjectModel.ObservableCollection<SomeUwpApp.SomeService.Setting> GetSettingsResult) {
            this.GetSettingsResult = GetSettingsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSettingsWithoutParams", WrapperNamespace="http://localhost/", IsWrapped=true)]
    public partial class GetSettingsWithoutParams {
        
        public GetSettingsWithoutParams() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSettingsWithoutParamsResponse", WrapperNamespace="http://localhost/", IsWrapped=true)]
    public partial class GetSettingsWithoutParams1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost/", Order=0)]
        public string GetSettingsWithoutParamsResult;
        
        public GetSettingsWithoutParams1() {
        }
        
        public GetSettingsWithoutParams1(string GetSettingsWithoutParamsResult) {
            this.GetSettingsWithoutParamsResult = GetSettingsWithoutParamsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : SomeUwpApp.SomeService.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<SomeUwpApp.SomeService.ServiceSoap>, SomeUwpApp.SomeService.ServiceSoap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceSoapClient() : 
                base(ServiceSoapClient.GetDefaultBinding(), ServiceSoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.ServiceSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), ServiceSoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SomeUwpApp.SomeService.GetSettingsResponse> SomeUwpApp.SomeService.ServiceSoap.GetSettingsAsync(SomeUwpApp.SomeService.GetSettingsRequest request) {
            return base.Channel.GetSettingsAsync(request);
        }
        
        public System.Threading.Tasks.Task<SomeUwpApp.SomeService.GetSettingsResponse> GetSettingsAsync(string searchField) {
            SomeUwpApp.SomeService.GetSettingsRequest inValue = new SomeUwpApp.SomeService.GetSettingsRequest();
            inValue.Body = new SomeUwpApp.SomeService.GetSettingsRequestBody();
            inValue.Body.searchField = searchField;
            return ((SomeUwpApp.SomeService.ServiceSoap)(this)).GetSettingsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SomeUwpApp.SomeService.GetSettingsWithoutParams1> SomeUwpApp.SomeService.ServiceSoap.GetSettings1Async(SomeUwpApp.SomeService.GetSettingsWithoutParams request) {
            return base.Channel.GetSettings1Async(request);
        }
        
        public System.Threading.Tasks.Task<SomeUwpApp.SomeService.GetSettingsWithoutParams1> GetSettings1Async() {
            SomeUwpApp.SomeService.GetSettingsWithoutParams inValue = new SomeUwpApp.SomeService.GetSettingsWithoutParams();
            return ((SomeUwpApp.SomeService.ServiceSoap)(this)).GetSettings1Async(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.ServiceSoap)) {
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
            if ((endpointConfiguration == EndpointConfiguration.ServiceSoap)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:57526/Service.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return ServiceSoapClient.GetBindingForEndpoint(EndpointConfiguration.ServiceSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return ServiceSoapClient.GetEndpointAddress(EndpointConfiguration.ServiceSoap);
        }
        
        public enum EndpointConfiguration {
            
            ServiceSoap,
        }
    }
}
