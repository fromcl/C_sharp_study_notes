﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.19462
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.19462 版自动生成。
// 
#pragma warning disable 1591

namespace WeatherClient.WeatherService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.19462")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://www.wrox.com/webservices")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ReverseStringOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetWeatherOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::WeatherClient.Properties.Settings.Default.WeatherClient_WeatherService_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ReverseStringCompletedEventHandler ReverseStringCompleted;
        
        /// <remarks/>
        public event GetWeatherCompletedEventHandler GetWeatherCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.wrox.com/webservices/ReverseString", RequestNamespace="http://www.wrox.com/webservices", ResponseNamespace="http://www.wrox.com/webservices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ReverseString(string message) {
            object[] results = this.Invoke("ReverseString", new object[] {
                        message});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ReverseStringAsync(string message) {
            this.ReverseStringAsync(message, null);
        }
        
        /// <remarks/>
        public void ReverseStringAsync(string message, object userState) {
            if ((this.ReverseStringOperationCompleted == null)) {
                this.ReverseStringOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReverseStringOperationCompleted);
            }
            this.InvokeAsync("ReverseString", new object[] {
                        message}, this.ReverseStringOperationCompleted, userState);
        }
        
        private void OnReverseStringOperationCompleted(object arg) {
            if ((this.ReverseStringCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReverseStringCompleted(this, new ReverseStringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.wrox.com/webservices/GetWeather", RequestNamespace="http://www.wrox.com/webservices", ResponseNamespace="http://www.wrox.com/webservices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GetWeatherResponse GetWeather(GetWeatherRequest req) {
            object[] results = this.Invoke("GetWeather", new object[] {
                        req});
            return ((GetWeatherResponse)(results[0]));
        }
        
        /// <remarks/>
        public void GetWeatherAsync(GetWeatherRequest req) {
            this.GetWeatherAsync(req, null);
        }
        
        /// <remarks/>
        public void GetWeatherAsync(GetWeatherRequest req, object userState) {
            if ((this.GetWeatherOperationCompleted == null)) {
                this.GetWeatherOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetWeatherOperationCompleted);
            }
            this.InvokeAsync("GetWeather", new object[] {
                        req}, this.GetWeatherOperationCompleted, userState);
        }
        
        private void OnGetWeatherOperationCompleted(object arg) {
            if ((this.GetWeatherCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetWeatherCompleted(this, new GetWeatherCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.19462")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/webservices")]
    public partial class GetWeatherRequest {
        
        private string cityField;
        
        private TemperatureType temperatureTypeField;
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public TemperatureType TemperatureType {
            get {
                return this.temperatureTypeField;
            }
            set {
                this.temperatureTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.19462")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/webservices")]
    public enum TemperatureType {
        
        /// <remarks/>
        Fahrenheit,
        
        /// <remarks/>
        Celsius,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.19462")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/webservices")]
    public partial class GetWeatherResponse {
        
        private TemparatureCondition conditionField;
        
        private int temperatureField;
        
        /// <remarks/>
        public TemparatureCondition Condition {
            get {
                return this.conditionField;
            }
            set {
                this.conditionField = value;
            }
        }
        
        /// <remarks/>
        public int Temperature {
            get {
                return this.temperatureField;
            }
            set {
                this.temperatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.19462")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wrox.com/webservices")]
    public enum TemparatureCondition {
        
        /// <remarks/>
        Rainy,
        
        /// <remarks/>
        Sunny,
        
        /// <remarks/>
        Cloudy,
        
        /// <remarks/>
        Thunderstorm,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.19462")]
    public delegate void ReverseStringCompletedEventHandler(object sender, ReverseStringCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.19462")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReverseStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReverseStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.19462")]
    public delegate void GetWeatherCompletedEventHandler(object sender, GetWeatherCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.19462")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetWeatherCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetWeatherCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetWeatherResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetWeatherResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591