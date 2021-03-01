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
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace TodoASMX.Droid.ASMXService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TodoServiceSoap", Namespace="http://www.xamarin.com/webservices/")]
    public partial class TodoService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetTodoItemsOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateTodoItemOperationCompleted;
        
        private System.Threading.SendOrPostCallback EditTodoItemOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteTodoItemOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TodoService() {
            this.Url = "http://localhost:49178/TodoService.asmx";
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
        public event GetTodoItemsCompletedEventHandler GetTodoItemsCompleted;
        
        /// <remarks/>
        public event CreateTodoItemCompletedEventHandler CreateTodoItemCompleted;
        
        /// <remarks/>
        public event EditTodoItemCompletedEventHandler EditTodoItemCompleted;
        
        /// <remarks/>
        public event DeleteTodoItemCompletedEventHandler DeleteTodoItemCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.xamarin.com/webservices/GetTodoItems", RequestNamespace="http://www.xamarin.com/webservices/", ResponseNamespace="http://www.xamarin.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TodoItem[] GetTodoItems() {
            object[] results = this.Invoke("GetTodoItems", new object[0]);
            return ((TodoItem[])(results[0]));
        }
        
        /// <remarks/>
        public void GetTodoItemsAsync() {
            this.GetTodoItemsAsync(null);
        }
        
        /// <remarks/>
        public void GetTodoItemsAsync(object userState) {
            if ((this.GetTodoItemsOperationCompleted == null)) {
                this.GetTodoItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTodoItemsOperationCompleted);
            }
            this.InvokeAsync("GetTodoItems", new object[0], this.GetTodoItemsOperationCompleted, userState);
        }
        
        private void OnGetTodoItemsOperationCompleted(object arg) {
            if ((this.GetTodoItemsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTodoItemsCompleted(this, new GetTodoItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.xamarin.com/webservices/CreateTodoItem", RequestNamespace="http://www.xamarin.com/webservices/", ResponseNamespace="http://www.xamarin.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateTodoItem(TodoItem item) {
            this.Invoke("CreateTodoItem", new object[] {
                        item});
        }
        
        /// <remarks/>
        public void CreateTodoItemAsync(TodoItem item) {
            this.CreateTodoItemAsync(item, null);
        }
        
        /// <remarks/>
        public void CreateTodoItemAsync(TodoItem item, object userState) {
            if ((this.CreateTodoItemOperationCompleted == null)) {
                this.CreateTodoItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateTodoItemOperationCompleted);
            }
            this.InvokeAsync("CreateTodoItem", new object[] {
                        item}, this.CreateTodoItemOperationCompleted, userState);
        }
        
        private void OnCreateTodoItemOperationCompleted(object arg) {
            if ((this.CreateTodoItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateTodoItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.xamarin.com/webservices/EditTodoItem", RequestNamespace="http://www.xamarin.com/webservices/", ResponseNamespace="http://www.xamarin.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EditTodoItem(TodoItem item) {
            this.Invoke("EditTodoItem", new object[] {
                        item});
        }
        
        /// <remarks/>
        public void EditTodoItemAsync(TodoItem item) {
            this.EditTodoItemAsync(item, null);
        }
        
        /// <remarks/>
        public void EditTodoItemAsync(TodoItem item, object userState) {
            if ((this.EditTodoItemOperationCompleted == null)) {
                this.EditTodoItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEditTodoItemOperationCompleted);
            }
            this.InvokeAsync("EditTodoItem", new object[] {
                        item}, this.EditTodoItemOperationCompleted, userState);
        }
        
        private void OnEditTodoItemOperationCompleted(object arg) {
            if ((this.EditTodoItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EditTodoItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.xamarin.com/webservices/DeleteTodoItem", RequestNamespace="http://www.xamarin.com/webservices/", ResponseNamespace="http://www.xamarin.com/webservices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteTodoItem(string id) {
            this.Invoke("DeleteTodoItem", new object[] {
                        id});
        }
        
        /// <remarks/>
        public void DeleteTodoItemAsync(string id) {
            this.DeleteTodoItemAsync(id, null);
        }
        
        /// <remarks/>
        public void DeleteTodoItemAsync(string id, object userState) {
            if ((this.DeleteTodoItemOperationCompleted == null)) {
                this.DeleteTodoItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteTodoItemOperationCompleted);
            }
            this.InvokeAsync("DeleteTodoItem", new object[] {
                        id}, this.DeleteTodoItemOperationCompleted, userState);
        }
        
        private void OnDeleteTodoItemOperationCompleted(object arg) {
            if ((this.DeleteTodoItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteTodoItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xamarin.com/webservices/")]
    public partial class TodoItem {
        
        private string idField;
        
        private string nameField;

        private string phoneField;

        private string departmentField;

        private string streetField;

        private string cityField;

        private string stateField;

        private string zipField;

        private string countryField;

        //private string notesField;

        //private bool doneField;

        /// <remarks/>
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        public string Department
        {
            get
            {
                return this.departmentField;
            }
            set
            {
                this.departmentField = value;
            }
        }

        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        public string ZIP
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        //public string Notes {
        //    get {
        //        return this.notesField;
        //    }
        //    set {
        //        this.notesField = value;
        //    }
        //}

        /// <remarks/>
        //public bool Done {
        //    get {
        //        return this.doneField;
        //    }
        //    set {
        //        this.doneField = value;
        //    }
        //}

        //public string Address { get; internal set; }
        //public int Age { get; internal set; }
        //public string AllowedToDrive { get; internal set; }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void GetTodoItemsCompletedEventHandler(object sender, GetTodoItemsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTodoItemsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTodoItemsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TodoItem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TodoItem[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void CreateTodoItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void EditTodoItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void DeleteTodoItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591