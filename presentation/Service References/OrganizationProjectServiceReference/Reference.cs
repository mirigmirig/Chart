﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace presentation.OrganizationProjectServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BasicResponce", Namespace="http://schemas.datacontract.org/2004/07/OrganizationProject.Service.ServiceObject" +
        "s.Responces")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(presentation.OrganizationProjectServiceReference.ChartDTOResponce))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(presentation.OrganizationProjectServiceReference.EmployeeRoleDTOResponce))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(presentation.OrganizationProjectServiceReference.OrganizationDTOResponce))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(presentation.OrganizationProjectServiceReference.EmployeeDTOResponce))]
    public partial class BasicResponce : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSucsessfullField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSucsessfull {
            get {
                return this.IsSucsessfullField;
            }
            set {
                if ((this.IsSucsessfullField.Equals(value) != true)) {
                    this.IsSucsessfullField = value;
                    this.RaisePropertyChanged("IsSucsessfull");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ChartDTOResponce", Namespace="http://schemas.datacontract.org/2004/07/OrganizationProject.Service.ServiceObject" +
        "s.Responces")]
    [System.SerializableAttribute()]
    public partial class ChartDTOResponce : presentation.OrganizationProjectServiceReference.BasicResponce {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeDTObject> ChartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeVerbDTObject> VerboseChartField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeDTObject> Chart {
            get {
                return this.ChartField;
            }
            set {
                if ((object.ReferenceEquals(this.ChartField, value) != true)) {
                    this.ChartField = value;
                    this.RaisePropertyChanged("Chart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeVerbDTObject> VerboseChart {
            get {
                return this.VerboseChartField;
            }
            set {
                if ((object.ReferenceEquals(this.VerboseChartField, value) != true)) {
                    this.VerboseChartField = value;
                    this.RaisePropertyChanged("VerboseChart");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeRoleDTOResponce", Namespace="http://schemas.datacontract.org/2004/07/OrganizationProject.Service.ServiceObject" +
        "s.Responces")]
    [System.SerializableAttribute()]
    public partial class EmployeeRoleDTOResponce : presentation.OrganizationProjectServiceReference.BasicResponce {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeRoleDTObject> AllRolesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private presentation.OrganizationProjectServiceReference.EmployeeRoleDTObject RoleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeRoleDTObject> AllRoles {
            get {
                return this.AllRolesField;
            }
            set {
                if ((object.ReferenceEquals(this.AllRolesField, value) != true)) {
                    this.AllRolesField = value;
                    this.RaisePropertyChanged("AllRoles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public presentation.OrganizationProjectServiceReference.EmployeeRoleDTObject Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrganizationDTOResponce", Namespace="http://schemas.datacontract.org/2004/07/OrganizationProject.Service.ServiceObject" +
        "s.Responces")]
    [System.SerializableAttribute()]
    public partial class OrganizationDTOResponce : presentation.OrganizationProjectServiceReference.BasicResponce {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private presentation.OrganizationProjectServiceReference.OrganizationDTObject OrganizationField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public presentation.OrganizationProjectServiceReference.OrganizationDTObject Organization {
            get {
                return this.OrganizationField;
            }
            set {
                if ((object.ReferenceEquals(this.OrganizationField, value) != true)) {
                    this.OrganizationField = value;
                    this.RaisePropertyChanged("Organization");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeDTOResponce", Namespace="http://schemas.datacontract.org/2004/07/OrganizationProject.Service.ServiceObject" +
        "s.Responces")]
    [System.SerializableAttribute()]
    public partial class EmployeeDTOResponce : presentation.OrganizationProjectServiceReference.BasicResponce {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeDTObject> AllEmployeesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private presentation.OrganizationProjectServiceReference.EmployeeDTObject EmployeeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeDTObject> AllEmployees {
            get {
                return this.AllEmployeesField;
            }
            set {
                if ((object.ReferenceEquals(this.AllEmployeesField, value) != true)) {
                    this.AllEmployeesField = value;
                    this.RaisePropertyChanged("AllEmployees");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public presentation.OrganizationProjectServiceReference.EmployeeDTObject Employee {
            get {
                return this.EmployeeField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeField, value) != true)) {
                    this.EmployeeField = value;
                    this.RaisePropertyChanged("Employee");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeDTObject", Namespace="http://schemas.datacontract.org/2004/07/OrganizationProject.Service.ServiceObject" +
        "s")]
    [System.SerializableAttribute()]
    public partial class EmployeeDTObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeRoleIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrganizationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ReportToEmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeDTObject> ReportingManageesField;
        
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
        public int EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeRoleID {
            get {
                return this.EmployeeRoleIDField;
            }
            set {
                if ((this.EmployeeRoleIDField.Equals(value) != true)) {
                    this.EmployeeRoleIDField = value;
                    this.RaisePropertyChanged("EmployeeRoleID");
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
        public int OrganizationID {
            get {
                return this.OrganizationIDField;
            }
            set {
                if ((this.OrganizationIDField.Equals(value) != true)) {
                    this.OrganizationIDField = value;
                    this.RaisePropertyChanged("OrganizationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ReportToEmployeeID {
            get {
                return this.ReportToEmployeeIDField;
            }
            set {
                if ((this.ReportToEmployeeIDField.Equals(value) != true)) {
                    this.ReportToEmployeeIDField = value;
                    this.RaisePropertyChanged("ReportToEmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeDTObject> ReportingManagees {
            get {
                return this.ReportingManageesField;
            }
            set {
                if ((object.ReferenceEquals(this.ReportingManageesField, value) != true)) {
                    this.ReportingManageesField = value;
                    this.RaisePropertyChanged("ReportingManagees");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeVerbDTObject", Namespace="http://schemas.datacontract.org/2004/07/OrganizationProject.Service.ServiceObject" +
        "s")]
    [System.SerializableAttribute()]
    public partial class EmployeeVerbDTObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeRoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrganizationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ReportToEmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeVerbDTObject> ReportingManageesField;
        
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
        public int EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeRole {
            get {
                return this.EmployeeRoleField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeRoleField, value) != true)) {
                    this.EmployeeRoleField = value;
                    this.RaisePropertyChanged("EmployeeRole");
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
        public int OrganizationID {
            get {
                return this.OrganizationIDField;
            }
            set {
                if ((this.OrganizationIDField.Equals(value) != true)) {
                    this.OrganizationIDField = value;
                    this.RaisePropertyChanged("OrganizationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ReportToEmployeeID {
            get {
                return this.ReportToEmployeeIDField;
            }
            set {
                if ((this.ReportToEmployeeIDField.Equals(value) != true)) {
                    this.ReportToEmployeeIDField = value;
                    this.RaisePropertyChanged("ReportToEmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<presentation.OrganizationProjectServiceReference.EmployeeVerbDTObject> ReportingManagees {
            get {
                return this.ReportingManageesField;
            }
            set {
                if ((object.ReferenceEquals(this.ReportingManageesField, value) != true)) {
                    this.ReportingManageesField = value;
                    this.RaisePropertyChanged("ReportingManagees");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeRoleDTObject", Namespace="http://schemas.datacontract.org/2004/07/OrganizationProject.Service.ServiceObject" +
        "s")]
    [System.SerializableAttribute()]
    public partial class EmployeeRoleDTObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeRoleDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeRoleIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeRoleNameField;
        
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
        public string EmployeeRoleDescription {
            get {
                return this.EmployeeRoleDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeRoleDescriptionField, value) != true)) {
                    this.EmployeeRoleDescriptionField = value;
                    this.RaisePropertyChanged("EmployeeRoleDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeRoleID {
            get {
                return this.EmployeeRoleIDField;
            }
            set {
                if ((this.EmployeeRoleIDField.Equals(value) != true)) {
                    this.EmployeeRoleIDField = value;
                    this.RaisePropertyChanged("EmployeeRoleID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeRoleName {
            get {
                return this.EmployeeRoleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeRoleNameField, value) != true)) {
                    this.EmployeeRoleNameField = value;
                    this.RaisePropertyChanged("EmployeeRoleName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OrganizationDTObject", Namespace="http://schemas.datacontract.org/2004/07/OrganizationProject.Service.ServiceObject" +
        "s")]
    [System.SerializableAttribute()]
    public partial class OrganizationDTObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrganizationDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrganizationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrganizationNameField;
        
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
        public string OrganizationDescription {
            get {
                return this.OrganizationDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.OrganizationDescriptionField, value) != true)) {
                    this.OrganizationDescriptionField = value;
                    this.RaisePropertyChanged("OrganizationDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrganizationID {
            get {
                return this.OrganizationIDField;
            }
            set {
                if ((this.OrganizationIDField.Equals(value) != true)) {
                    this.OrganizationIDField = value;
                    this.RaisePropertyChanged("OrganizationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OrganizationName {
            get {
                return this.OrganizationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.OrganizationNameField, value) != true)) {
                    this.OrganizationNameField = value;
                    this.RaisePropertyChanged("OrganizationName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrganizationProjectServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getEmployeeByID", ReplyAction="http://tempuri.org/IService/getEmployeeByIDResponse")]
        presentation.OrganizationProjectServiceReference.EmployeeDTOResponce getEmployeeByID(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getAllEmployees", ReplyAction="http://tempuri.org/IService/getAllEmployeesResponse")]
        presentation.OrganizationProjectServiceReference.EmployeeDTOResponce getAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/deleteEmployeeByID", ReplyAction="http://tempuri.org/IService/deleteEmployeeByIDResponse")]
        presentation.OrganizationProjectServiceReference.BasicResponce deleteEmployeeByID(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/editManagerByID", ReplyAction="http://tempuri.org/IService/editManagerByIDResponse")]
        presentation.OrganizationProjectServiceReference.BasicResponce editManagerByID(int EmpoyeeID, int ManagerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addEmployee", ReplyAction="http://tempuri.org/IService/addEmployeeResponse")]
        presentation.OrganizationProjectServiceReference.BasicResponce addEmployee(presentation.OrganizationProjectServiceReference.EmployeeDTObject Employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getChartScheme", ReplyAction="http://tempuri.org/IService/getChartSchemeResponse")]
        presentation.OrganizationProjectServiceReference.ChartDTOResponce getChartScheme();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getVerboseChartScheme", ReplyAction="http://tempuri.org/IService/getVerboseChartSchemeResponse")]
        presentation.OrganizationProjectServiceReference.ChartDTOResponce getVerboseChartScheme();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getEmployeeRoleByID", ReplyAction="http://tempuri.org/IService/getEmployeeRoleByIDResponse")]
        presentation.OrganizationProjectServiceReference.EmployeeRoleDTOResponce getEmployeeRoleByID(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getEmployeeRoles", ReplyAction="http://tempuri.org/IService/getEmployeeRolesResponse")]
        presentation.OrganizationProjectServiceReference.EmployeeRoleDTOResponce getEmployeeRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getOrganizationByID", ReplyAction="http://tempuri.org/IService/getOrganizationByIDResponse")]
        presentation.OrganizationProjectServiceReference.OrganizationDTOResponce getOrganizationByID(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : presentation.OrganizationProjectServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<presentation.OrganizationProjectServiceReference.IService>, presentation.OrganizationProjectServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public presentation.OrganizationProjectServiceReference.EmployeeDTOResponce getEmployeeByID(int Id) {
            return base.Channel.getEmployeeByID(Id);
        }
        
        public presentation.OrganizationProjectServiceReference.EmployeeDTOResponce getAllEmployees() {
            return base.Channel.getAllEmployees();
        }
        
        public presentation.OrganizationProjectServiceReference.BasicResponce deleteEmployeeByID(int Id) {
            return base.Channel.deleteEmployeeByID(Id);
        }
        
        public presentation.OrganizationProjectServiceReference.BasicResponce editManagerByID(int EmpoyeeID, int ManagerID) {
            return base.Channel.editManagerByID(EmpoyeeID, ManagerID);
        }
        
        public presentation.OrganizationProjectServiceReference.BasicResponce addEmployee(presentation.OrganizationProjectServiceReference.EmployeeDTObject Employee) {
            return base.Channel.addEmployee(Employee);
        }
        
        public presentation.OrganizationProjectServiceReference.ChartDTOResponce getChartScheme() {
            return base.Channel.getChartScheme();
        }
        
        public presentation.OrganizationProjectServiceReference.ChartDTOResponce getVerboseChartScheme() {
            return base.Channel.getVerboseChartScheme();
        }
        
        public presentation.OrganizationProjectServiceReference.EmployeeRoleDTOResponce getEmployeeRoleByID(int Id) {
            return base.Channel.getEmployeeRoleByID(Id);
        }
        
        public presentation.OrganizationProjectServiceReference.EmployeeRoleDTOResponce getEmployeeRoles() {
            return base.Channel.getEmployeeRoles();
        }
        
        public presentation.OrganizationProjectServiceReference.OrganizationDTOResponce getOrganizationByID(int Id) {
            return base.Channel.getOrganizationByID(Id);
        }
    }
}
