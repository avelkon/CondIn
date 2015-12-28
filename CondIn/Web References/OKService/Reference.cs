﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18444
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Этот исходный текст был создан автоматически: Microsoft.VSDesigner, версия: 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace CondIn.OKService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_ISIntegrationSoap", Namespace="http://tempuri.org/")]
    public partial class WS_ISIntegration : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback UploadFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetAsync1OperationCompleted;
        
        private System.Threading.SendOrPostCallback SetAsync_ResultGetOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_ISIntegration() {
            this.Url = global::CondIn.Properties.Settings.Default.CondIn_OKService_WS_ISIntegration;
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
        public event UploadFileCompletedEventHandler UploadFileCompleted;
        
        /// <remarks/>
        public event GetCompletedEventHandler GetCompleted;
        
        /// <remarks/>
        public event SetCompletedEventHandler SetCompleted;
        
        /// <remarks/>
        public event SetAsync1CompletedEventHandler SetAsync1Completed;
        
        /// <remarks/>
        public event SetAsync_ResultGetCompletedEventHandler SetAsync_ResultGetCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UploadFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Err", IsNullable=true)]
        public ResultService UploadFile(string login, string password, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] file, string fileName) {
            object[] results = this.Invoke("UploadFile", new object[] {
                        login,
                        password,
                        file,
                        fileName});
            return ((ResultService)(results[0]));
        }
        
        /// <remarks/>
        public void UploadFileAsync(string login, string password, byte[] file, string fileName) {
            this.UploadFileAsync(login, password, file, fileName, null);
        }
        
        /// <remarks/>
        public void UploadFileAsync(string login, string password, byte[] file, string fileName, object userState) {
            if ((this.UploadFileOperationCompleted == null)) {
                this.UploadFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadFileOperationCompleted);
            }
            this.InvokeAsync("UploadFile", new object[] {
                        login,
                        password,
                        file,
                        fileName}, this.UploadFileOperationCompleted, userState);
        }
        
        private void OnUploadFileOperationCompleted(object arg) {
            if ((this.UploadFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadFileCompleted(this, new UploadFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("ResultRow")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("Field", IsNullable=false, NestingLevel=1)]
        public ResultRowField[][] Get(string login, string pass, string Procedure) {
            object[] results = this.Invoke("Get", new object[] {
                        login,
                        pass,
                        Procedure});
            return ((ResultRowField[][])(results[0]));
        }
        
        /// <remarks/>
        public void GetAsync(string login, string pass, string Procedure) {
            this.GetAsync(login, pass, Procedure, null);
        }
        
        /// <remarks/>
        public void GetAsync(string login, string pass, string Procedure, object userState) {
            if ((this.GetOperationCompleted == null)) {
                this.GetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOperationCompleted);
            }
            this.InvokeAsync("Get", new object[] {
                        login,
                        pass,
                        Procedure}, this.GetOperationCompleted, userState);
        }
        
        private void OnGetOperationCompleted(object arg) {
            if ((this.GetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCompleted(this, new GetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Set", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Err", IsNullable=true)]
        public ResultService Set(string login, string pass, string Procedure) {
            object[] results = this.Invoke("Set", new object[] {
                        login,
                        pass,
                        Procedure});
            return ((ResultService)(results[0]));
        }
        
        /// <remarks/>
        public void SetAsync(string login, string pass, string Procedure) {
            this.SetAsync(login, pass, Procedure, null);
        }
        
        /// <remarks/>
        public void SetAsync(string login, string pass, string Procedure, object userState) {
            if ((this.SetOperationCompleted == null)) {
                this.SetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetOperationCompleted);
            }
            this.InvokeAsync("Set", new object[] {
                        login,
                        pass,
                        Procedure}, this.SetOperationCompleted, userState);
        }
        
        private void OnSetOperationCompleted(object arg) {
            if ((this.SetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetCompleted(this, new SetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.WebMethodAttribute(MessageName="SetAsync1")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetAsync", RequestElementName="SetAsync", RequestNamespace="http://tempuri.org/", ResponseElementName="SetAsyncResponse", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Err", IsNullable=true)]
        public ResultService SetAsync(string login, string pass, string ProcedureName, string Data) {
            object[] results = this.Invoke("SetAsync1", new object[] {
                        login,
                        pass,
                        ProcedureName,
                        Data});
            return ((ResultService)(results[0]));
        }
        
        /// <remarks/>
        public void SetAsync1Async(string login, string pass, string ProcedureName, string Data) {
            this.SetAsync1Async(login, pass, ProcedureName, Data, null);
        }
        
        /// <remarks/>
        public void SetAsync1Async(string login, string pass, string ProcedureName, string Data, object userState) {
            if ((this.SetAsync1OperationCompleted == null)) {
                this.SetAsync1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetAsync1OperationCompleted);
            }
            this.InvokeAsync("SetAsync1", new object[] {
                        login,
                        pass,
                        ProcedureName,
                        Data}, this.SetAsync1OperationCompleted, userState);
        }
        
        private void OnSetAsync1OperationCompleted(object arg) {
            if ((this.SetAsync1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetAsync1Completed(this, new SetAsync1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetAsync_ResultGet", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Err", IsNullable=true)]
        public ResultService SetAsync_ResultGet(string login, string pass, string guid) {
            object[] results = this.Invoke("SetAsync_ResultGet", new object[] {
                        login,
                        pass,
                        guid});
            return ((ResultService)(results[0]));
        }
        
        /// <remarks/>
        public void SetAsync_ResultGetAsync(string login, string pass, string guid) {
            this.SetAsync_ResultGetAsync(login, pass, guid, null);
        }
        
        /// <remarks/>
        public void SetAsync_ResultGetAsync(string login, string pass, string guid, object userState) {
            if ((this.SetAsync_ResultGetOperationCompleted == null)) {
                this.SetAsync_ResultGetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetAsync_ResultGetOperationCompleted);
            }
            this.InvokeAsync("SetAsync_ResultGet", new object[] {
                        login,
                        pass,
                        guid}, this.SetAsync_ResultGetOperationCompleted, userState);
        }
        
        private void OnSetAsync_ResultGetOperationCompleted(object arg) {
            if ((this.SetAsync_ResultGetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetAsync_ResultGetCompleted(this, new SetAsync_ResultGetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ResultService : ResultRow {
        
        private string statusField;
        
        private string textField;
        
        private string dataField;
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string Data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResultService))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ResultRow {
        
        private ResultRowField[] fieldField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Field")]
        public ResultRowField[] Field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ResultRowField {
        
        private string valueField;
        
        private string nameField;
        
        private ProcedureFieldType typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ProcedureFieldType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum ProcedureFieldType {
        
        /// <remarks/>
        STRING,
        
        /// <remarks/>
        GUID,
        
        /// <remarks/>
        INT,
        
        /// <remarks/>
        DECIMAL,
        
        /// <remarks/>
        DATETIME,
        
        /// <remarks/>
        IMAGE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void UploadFileCompletedEventHandler(object sender, UploadFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UploadFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResultService Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResultService)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetCompletedEventHandler(object sender, GetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResultRowField[][] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResultRowField[][])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SetCompletedEventHandler(object sender, SetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResultService Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResultService)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SetAsync1CompletedEventHandler(object sender, SetAsync1CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetAsync1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SetAsync1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResultService Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResultService)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SetAsync_ResultGetCompletedEventHandler(object sender, SetAsync_ResultGetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetAsync_ResultGetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SetAsync_ResultGetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResultService Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResultService)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591