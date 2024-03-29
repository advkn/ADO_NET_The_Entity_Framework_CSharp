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

[assembly: EdmRelationshipAttribute("AutoLotModel", "FK_Orders_Customers", "Customers", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(AutoLotDAL.Customer), "Orders", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(AutoLotDAL.Order), true)]
[assembly: EdmRelationshipAttribute("AutoLotModel", "FK_Orders_Inventory", "Inventory", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(AutoLotDAL.Inventory), "Orders", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(AutoLotDAL.Order), true)]

#endregion

namespace AutoLotDAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AutoLotEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AutoLotEntities object using the connection string found in the 'AutoLotEntities' section of the application configuration file.
        /// </summary>
        public AutoLotEntities() : base("name=AutoLotEntities", "AutoLotEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AutoLotEntities object.
        /// </summary>
        public AutoLotEntities(string connectionString) : base(connectionString, "AutoLotEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AutoLotEntities object.
        /// </summary>
        public AutoLotEntities(EntityConnection connection) : base(connection, "AutoLotEntities")
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
        public ObjectSet<Customer> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customer>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customer> _Customers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Inventory> Inventories
        {
            get
            {
                if ((_Inventories == null))
                {
                    _Inventories = base.CreateObjectSet<Inventory>("Inventories");
                }
                return _Inventories;
            }
        }
        private ObjectSet<Inventory> _Inventories;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Customers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Inventories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToInventories(Inventory inventory)
        {
            base.AddObject("Inventories", inventory);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }

        #endregion

        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="carID">No Metadata Documentation available.</param>
        /// <param name="petName">No Metadata Documentation available.</param>
        public int GetPetName(Nullable<global::System.Int32> carID, ObjectParameter petName)
        {
            ObjectParameter carIDParameter;
            if (carID.HasValue)
            {
                carIDParameter = new ObjectParameter("carID", carID);
            }
            else
            {
                carIDParameter = new ObjectParameter("carID", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction("GetPetName", carIDParameter, petName);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AutoLotModel", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="custID">Initial value of the CustID property.</param>
        public static Customer CreateCustomer(global::System.Int32 custID)
        {
            Customer customer = new Customer();
            customer.CustID = custID;
            return customer;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustID
        {
            get
            {
                return _CustID;
            }
            set
            {
                if (_CustID != value)
                {
                    OnCustIDChanging(value);
                    ReportPropertyChanging("CustID");
                    _CustID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CustID");
                    OnCustIDChanged();
                }
            }
        }
        private global::System.Int32 _CustID;
        partial void OnCustIDChanging(global::System.Int32 value);
        partial void OnCustIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
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
                _FirstName = StructuralObject.SetValidValue(value, true);
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
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
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AutoLotModel", "FK_Orders_Customers", "Orders")]
        public EntityCollection<Order> Orders
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Order>("AutoLotModel.FK_Orders_Customers", "Orders");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Order>("AutoLotModel.FK_Orders_Customers", "Orders", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AutoLotModel", Name="Inventory")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Inventory : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Inventory object.
        /// </summary>
        /// <param name="carID">Initial value of the CarID property.</param>
        /// <param name="petName">Initial value of the PetName property.</param>
        public static Inventory CreateInventory(global::System.Int32 carID, global::System.String petName)
        {
            Inventory inventory = new Inventory();
            inventory.CarID = carID;
            inventory.PetName = petName;
            return inventory;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CarID
        {
            get
            {
                return _CarID;
            }
            set
            {
                if (_CarID != value)
                {
                    OnCarIDChanging(value);
                    ReportPropertyChanging("CarID");
                    _CarID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CarID");
                    OnCarIDChanged();
                }
            }
        }
        private global::System.Int32 _CarID;
        partial void OnCarIDChanging(global::System.Int32 value);
        partial void OnCarIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Make
        {
            get
            {
                return _Make;
            }
            set
            {
                OnMakeChanging(value);
                ReportPropertyChanging("Make");
                _Make = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Make");
                OnMakeChanged();
            }
        }
        private global::System.String _Make;
        partial void OnMakeChanging(global::System.String value);
        partial void OnMakeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Color
        {
            get
            {
                return _Color;
            }
            set
            {
                OnColorChanging(value);
                ReportPropertyChanging("Color");
                _Color = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Color");
                OnColorChanged();
            }
        }
        private global::System.String _Color;
        partial void OnColorChanging(global::System.String value);
        partial void OnColorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PetName
        {
            get
            {
                return _PetName;
            }
            set
            {
                OnPetNameChanging(value);
                ReportPropertyChanging("PetName");
                _PetName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PetName");
                OnPetNameChanged();
            }
        }
        private global::System.String _PetName;
        partial void OnPetNameChanging(global::System.String value);
        partial void OnPetNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AutoLotModel", "FK_Orders_Inventory", "Orders")]
        public EntityCollection<Order> Orders
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Order>("AutoLotModel.FK_Orders_Inventory", "Orders");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Order>("AutoLotModel.FK_Orders_Inventory", "Orders", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AutoLotModel", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderID">Initial value of the OrderID property.</param>
        /// <param name="custID">Initial value of the CustID property.</param>
        /// <param name="carID">Initial value of the CarID property.</param>
        public static Order CreateOrder(global::System.Int32 orderID, global::System.Int32 custID, global::System.Int32 carID)
        {
            Order order = new Order();
            order.OrderID = orderID;
            order.CustID = custID;
            order.CarID = carID;
            return order;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderID
        {
            get
            {
                return _OrderID;
            }
            set
            {
                if (_OrderID != value)
                {
                    OnOrderIDChanging(value);
                    ReportPropertyChanging("OrderID");
                    _OrderID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderID");
                    OnOrderIDChanged();
                }
            }
        }
        private global::System.Int32 _OrderID;
        partial void OnOrderIDChanging(global::System.Int32 value);
        partial void OnOrderIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustID
        {
            get
            {
                return _CustID;
            }
            set
            {
                OnCustIDChanging(value);
                ReportPropertyChanging("CustID");
                _CustID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CustID");
                OnCustIDChanged();
            }
        }
        private global::System.Int32 _CustID;
        partial void OnCustIDChanging(global::System.Int32 value);
        partial void OnCustIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CarID
        {
            get
            {
                return _CarID;
            }
            set
            {
                OnCarIDChanging(value);
                ReportPropertyChanging("CarID");
                _CarID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CarID");
                OnCarIDChanged();
            }
        }
        private global::System.Int32 _CarID;
        partial void OnCarIDChanging(global::System.Int32 value);
        partial void OnCarIDChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AutoLotModel", "FK_Orders_Customers", "Customers")]
        public Customer Customer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("AutoLotModel.FK_Orders_Customers", "Customers").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("AutoLotModel.FK_Orders_Customers", "Customers").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Customer> CustomerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("AutoLotModel.FK_Orders_Customers", "Customers");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("AutoLotModel.FK_Orders_Customers", "Customers", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AutoLotModel", "FK_Orders_Inventory", "Inventory")]
        public Inventory Inventory
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Inventory>("AutoLotModel.FK_Orders_Inventory", "Inventory").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Inventory>("AutoLotModel.FK_Orders_Inventory", "Inventory").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Inventory> InventoryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Inventory>("AutoLotModel.FK_Orders_Inventory", "Inventory");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Inventory>("AutoLotModel.FK_Orders_Inventory", "Inventory", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
