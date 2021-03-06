﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("OrganizationData_DBModel", "FK_EmployeesData_EmployeeRoleData", "EmployeeRoleData", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(OrganizationProject.DataAccess.EmployeeRoleData), "EmployeesData", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(OrganizationProject.DataAccess.EmployeesData), true)]
[assembly: EdmRelationshipAttribute("OrganizationData_DBModel", "FK_EmployeesData_EmployeesData", "EmployeesData", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(OrganizationProject.DataAccess.EmployeesData), "EmployeesData1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(OrganizationProject.DataAccess.EmployeesData), true)]
[assembly: EdmRelationshipAttribute("OrganizationData_DBModel", "FK_EmployeesData_OrganizationData", "OrganizationData", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(OrganizationProject.DataAccess.OrganizationData), "EmployeesData", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(OrganizationProject.DataAccess.EmployeesData), true)]

#endregion

namespace OrganizationProject.DataAccess
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class OrganizationData_DBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new OrganizationData_DBEntities object using the connection string found in the 'OrganizationData_DBEntities' section of the application configuration file.
        /// </summary>
        public OrganizationData_DBEntities() : base("name=OrganizationData_DBEntities", "OrganizationData_DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new OrganizationData_DBEntities object.
        /// </summary>
        public OrganizationData_DBEntities(string connectionString) : base(connectionString, "OrganizationData_DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new OrganizationData_DBEntities object.
        /// </summary>
        public OrganizationData_DBEntities(EntityConnection connection) : base(connection, "OrganizationData_DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EmployeeRoleData> EmployeeRoleDatas
        {
            get
            {
                if ((_EmployeeRoleDatas == null))
                {
                    _EmployeeRoleDatas = base.CreateObjectSet<EmployeeRoleData>("EmployeeRoleDatas");
                }
                return _EmployeeRoleDatas;
            }
        }
        private ObjectSet<EmployeeRoleData> _EmployeeRoleDatas;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EmployeesData> EmployeesDatas
        {
            get
            {
                if ((_EmployeesDatas == null))
                {
                    _EmployeesDatas = base.CreateObjectSet<EmployeesData>("EmployeesDatas");
                }
                return _EmployeesDatas;
            }
        }
        private ObjectSet<EmployeesData> _EmployeesDatas;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OrganizationData> OrganizationDatas
        {
            get
            {
                if ((_OrganizationDatas == null))
                {
                    _OrganizationDatas = base.CreateObjectSet<OrganizationData>("OrganizationDatas");
                }
                return _OrganizationDatas;
            }
        }
        private ObjectSet<OrganizationData> _OrganizationDatas;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EmployeeRoleDatas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployeeRoleDatas(EmployeeRoleData employeeRoleData)
        {
            base.AddObject("EmployeeRoleDatas", employeeRoleData);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EmployeesDatas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployeesDatas(EmployeesData employeesData)
        {
            base.AddObject("EmployeesDatas", employeesData);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the OrganizationDatas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrganizationDatas(OrganizationData organizationData)
        {
            base.AddObject("OrganizationDatas", organizationData);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="OrganizationData_DBModel", Name="EmployeeRoleData")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EmployeeRoleData : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EmployeeRoleData object.
        /// </summary>
        /// <param name="employeeRoleID">Initial value of the EmployeeRoleID property.</param>
        /// <param name="employeeRoleName">Initial value of the EmployeeRoleName property.</param>
        /// <param name="employeeRoleDescription">Initial value of the EmployeeRoleDescription property.</param>
        public static EmployeeRoleData CreateEmployeeRoleData(global::System.Int32 employeeRoleID, global::System.String employeeRoleName, global::System.String employeeRoleDescription)
        {
            EmployeeRoleData employeeRoleData = new EmployeeRoleData();
            employeeRoleData.EmployeeRoleID = employeeRoleID;
            employeeRoleData.EmployeeRoleName = employeeRoleName;
            employeeRoleData.EmployeeRoleDescription = employeeRoleDescription;
            return employeeRoleData;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeRoleID
        {
            get
            {
                return _EmployeeRoleID;
            }
            set
            {
                if (_EmployeeRoleID != value)
                {
                    OnEmployeeRoleIDChanging(value);
                    ReportPropertyChanging("EmployeeRoleID");
                    _EmployeeRoleID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmployeeRoleID");
                    OnEmployeeRoleIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeRoleID;
        partial void OnEmployeeRoleIDChanging(global::System.Int32 value);
        partial void OnEmployeeRoleIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmployeeRoleName
        {
            get
            {
                return _EmployeeRoleName;
            }
            set
            {
                OnEmployeeRoleNameChanging(value);
                ReportPropertyChanging("EmployeeRoleName");
                _EmployeeRoleName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EmployeeRoleName");
                OnEmployeeRoleNameChanged();
            }
        }
        private global::System.String _EmployeeRoleName;
        partial void OnEmployeeRoleNameChanging(global::System.String value);
        partial void OnEmployeeRoleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmployeeRoleDescription
        {
            get
            {
                return _EmployeeRoleDescription;
            }
            set
            {
                OnEmployeeRoleDescriptionChanging(value);
                ReportPropertyChanging("EmployeeRoleDescription");
                _EmployeeRoleDescription = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EmployeeRoleDescription");
                OnEmployeeRoleDescriptionChanged();
            }
        }
        private global::System.String _EmployeeRoleDescription;
        partial void OnEmployeeRoleDescriptionChanging(global::System.String value);
        partial void OnEmployeeRoleDescriptionChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("OrganizationData_DBModel", "FK_EmployeesData_EmployeeRoleData", "EmployeesData")]
        public EntityCollection<EmployeesData> EmployeesDatas
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EmployeesData>("OrganizationData_DBModel.FK_EmployeesData_EmployeeRoleData", "EmployeesData");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EmployeesData>("OrganizationData_DBModel.FK_EmployeesData_EmployeeRoleData", "EmployeesData", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="OrganizationData_DBModel", Name="EmployeesData")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EmployeesData : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EmployeesData object.
        /// </summary>
        /// <param name="employeeID">Initial value of the EmployeeID property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="employeeRoleID">Initial value of the EmployeeRoleID property.</param>
        /// <param name="organizationID">Initial value of the OrganizationID property.</param>
        public static EmployeesData CreateEmployeesData(global::System.Int32 employeeID, global::System.String firstName, global::System.String lastName, global::System.Int32 employeeRoleID, global::System.Int32 organizationID)
        {
            EmployeesData employeesData = new EmployeesData();
            employeesData.EmployeeID = employeeID;
            employeesData.FirstName = firstName;
            employeesData.LastName = lastName;
            employeesData.EmployeeRoleID = employeeRoleID;
            employeesData.OrganizationID = organizationID;
            return employeesData;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (_EmployeeID != value)
                {
                    OnEmployeeIDChanging(value);
                    ReportPropertyChanging("EmployeeID");
                    _EmployeeID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmployeeID");
                    OnEmployeeIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Int32 value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeRoleID
        {
            get
            {
                return _EmployeeRoleID;
            }
            set
            {
                OnEmployeeRoleIDChanging(value);
                ReportPropertyChanging("EmployeeRoleID");
                _EmployeeRoleID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EmployeeRoleID");
                OnEmployeeRoleIDChanged();
            }
        }
        private global::System.Int32 _EmployeeRoleID;
        partial void OnEmployeeRoleIDChanging(global::System.Int32 value);
        partial void OnEmployeeRoleIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ReportsToEmployeeID
        {
            get
            {
                return _ReportsToEmployeeID;
            }
            set
            {
                OnReportsToEmployeeIDChanging(value);
                ReportPropertyChanging("ReportsToEmployeeID");
                _ReportsToEmployeeID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ReportsToEmployeeID");
                OnReportsToEmployeeIDChanged();
            }
        }
        private Nullable<global::System.Int32> _ReportsToEmployeeID;
        partial void OnReportsToEmployeeIDChanging(Nullable<global::System.Int32> value);
        partial void OnReportsToEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrganizationID
        {
            get
            {
                return _OrganizationID;
            }
            set
            {
                OnOrganizationIDChanging(value);
                ReportPropertyChanging("OrganizationID");
                _OrganizationID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrganizationID");
                OnOrganizationIDChanged();
            }
        }
        private global::System.Int32 _OrganizationID;
        partial void OnOrganizationIDChanging(global::System.Int32 value);
        partial void OnOrganizationIDChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("OrganizationData_DBModel", "FK_EmployeesData_EmployeeRoleData", "EmployeeRoleData")]
        public EmployeeRoleData EmployeeRoleData
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeeRoleData>("OrganizationData_DBModel.FK_EmployeesData_EmployeeRoleData", "EmployeeRoleData").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeeRoleData>("OrganizationData_DBModel.FK_EmployeesData_EmployeeRoleData", "EmployeeRoleData").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<EmployeeRoleData> EmployeeRoleDataReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeeRoleData>("OrganizationData_DBModel.FK_EmployeesData_EmployeeRoleData", "EmployeeRoleData");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<EmployeeRoleData>("OrganizationData_DBModel.FK_EmployeesData_EmployeeRoleData", "EmployeeRoleData", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("OrganizationData_DBModel", "FK_EmployeesData_EmployeesData", "EmployeesData1")]
        public EntityCollection<EmployeesData> ChidEmployeesData
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EmployeesData>("OrganizationData_DBModel.FK_EmployeesData_EmployeesData", "EmployeesData1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EmployeesData>("OrganizationData_DBModel.FK_EmployeesData_EmployeesData", "EmployeesData1", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("OrganizationData_DBModel", "FK_EmployeesData_EmployeesData", "EmployeesData")]
        public EmployeesData ParentEmployeesData
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeesData>("OrganizationData_DBModel.FK_EmployeesData_EmployeesData", "EmployeesData").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeesData>("OrganizationData_DBModel.FK_EmployeesData_EmployeesData", "EmployeesData").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<EmployeesData> ParentEmployeesDataReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeesData>("OrganizationData_DBModel.FK_EmployeesData_EmployeesData", "EmployeesData");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<EmployeesData>("OrganizationData_DBModel.FK_EmployeesData_EmployeesData", "EmployeesData", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("OrganizationData_DBModel", "FK_EmployeesData_OrganizationData", "OrganizationData")]
        public OrganizationData OrganizationData
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<OrganizationData>("OrganizationData_DBModel.FK_EmployeesData_OrganizationData", "OrganizationData").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<OrganizationData>("OrganizationData_DBModel.FK_EmployeesData_OrganizationData", "OrganizationData").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<OrganizationData> OrganizationDataReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<OrganizationData>("OrganizationData_DBModel.FK_EmployeesData_OrganizationData", "OrganizationData");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<OrganizationData>("OrganizationData_DBModel.FK_EmployeesData_OrganizationData", "OrganizationData", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="OrganizationData_DBModel", Name="OrganizationData")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OrganizationData : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new OrganizationData object.
        /// </summary>
        /// <param name="organizationID">Initial value of the OrganizationID property.</param>
        /// <param name="organizationName">Initial value of the OrganizationName property.</param>
        /// <param name="organizationDecription">Initial value of the OrganizationDecription property.</param>
        public static OrganizationData CreateOrganizationData(global::System.Int32 organizationID, global::System.String organizationName, global::System.String organizationDecription)
        {
            OrganizationData organizationData = new OrganizationData();
            organizationData.OrganizationID = organizationID;
            organizationData.OrganizationName = organizationName;
            organizationData.OrganizationDecription = organizationDecription;
            return organizationData;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrganizationID
        {
            get
            {
                return _OrganizationID;
            }
            set
            {
                if (_OrganizationID != value)
                {
                    OnOrganizationIDChanging(value);
                    ReportPropertyChanging("OrganizationID");
                    _OrganizationID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrganizationID");
                    OnOrganizationIDChanged();
                }
            }
        }
        private global::System.Int32 _OrganizationID;
        partial void OnOrganizationIDChanging(global::System.Int32 value);
        partial void OnOrganizationIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OrganizationName
        {
            get
            {
                return _OrganizationName;
            }
            set
            {
                OnOrganizationNameChanging(value);
                ReportPropertyChanging("OrganizationName");
                _OrganizationName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("OrganizationName");
                OnOrganizationNameChanged();
            }
        }
        private global::System.String _OrganizationName;
        partial void OnOrganizationNameChanging(global::System.String value);
        partial void OnOrganizationNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OrganizationDecription
        {
            get
            {
                return _OrganizationDecription;
            }
            set
            {
                OnOrganizationDecriptionChanging(value);
                ReportPropertyChanging("OrganizationDecription");
                _OrganizationDecription = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("OrganizationDecription");
                OnOrganizationDecriptionChanged();
            }
        }
        private global::System.String _OrganizationDecription;
        partial void OnOrganizationDecriptionChanging(global::System.String value);
        partial void OnOrganizationDecriptionChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("OrganizationData_DBModel", "FK_EmployeesData_OrganizationData", "EmployeesData")]
        public EntityCollection<EmployeesData> EmployeesDatas
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EmployeesData>("OrganizationData_DBModel.FK_EmployeesData_OrganizationData", "EmployeesData");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EmployeesData>("OrganizationData_DBModel.FK_EmployeesData_OrganizationData", "EmployeesData", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
