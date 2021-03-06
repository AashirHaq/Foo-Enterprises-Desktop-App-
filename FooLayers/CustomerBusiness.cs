// Created using LayerGen 3.5

using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer.FooEnterprises
{
    [Serializable]
    public partial class Customer : DataLayer.FooEnterprises.Customer
    {
        public enum ConcurrencyOptions
        {
            /// <summary>
            /// Concurrency checking is disabled
            /// </summary>
            Ignore = 0,
            /// <summary>
            /// Concurrency checking is checked and an exception is thrown if the data changed
            /// </summary>
            Strict = 1
		}

        public enum Fields
        {
            CustomerId,
            FirstName,
            LastName
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer() : base()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        public Customer(LayerGenConnectionString connectionString) : base(connectionString)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class,
        /// optionally using stored procedures or Sql text.
        /// </summary>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        public Customer(bool useStoredProcedures) : base(useStoredProcedures)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class,
        /// optionally using stored procedures or Sql text.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        public Customer(LayerGenConnectionString connectionString, bool useStoredProcedures) : base(connectionString, useStoredProcedures)
        {
            
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key.
        /// </summary>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        public Customer(int id) : base(id)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        public Customer(LayerGenConnectionString connectionString, int id) : base(connectionString, id)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and optionally
        /// using stored procedures or Sql text.
        /// </summary>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        public Customer(int id, bool useStoredProcedures) : base(id, useStoredProcedures)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and optionally
        /// using stored procedures or Sql text.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        public Customer(LayerGenConnectionString connectionString, int id, bool useStoredProcedures) : base(connectionString, id, useStoredProcedures)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and loading
        /// only the fields specified.
        /// </summary>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="fields">The list of <see cref="BusinessLayer.FooEnterprises.Customer.Fields"/> to pull from the database.</param>
		public Customer(int id, List<Fields> fields) : base(id, fields)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and loading
        /// only the fields specified.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="fields">The list of <see cref="BusinessLayer.FooEnterprises.Customer.Fields"/> to pull from the database.</param>
		public Customer(LayerGenConnectionString connectionString, int id, List<Fields> fields) : base(connectionString, id, fields)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and loading
        /// only the fields specified. You can also specify if you want data access
        /// to be done with stored procedures or Sql text.
        /// </summary>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="fields">The list of <see cref="BusinessLayer.FooEnterprises.Customer.Fields"/> to pull from the database.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
		public Customer(int id, List<Fields> fields, bool useStoredProcedures) : base(id, fields, useStoredProcedures)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and loading
        /// only the fields specified. You can also specify if you want data access
        /// to be done with stored procedures or Sql text.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="fields">The list of <see cref="BusinessLayer.FooEnterprises.Customer.Fields"/> to pull from the database.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
		public Customer(LayerGenConnectionString connectionString, int id, List<Fields> fields, bool useStoredProcedures) : base(connectionString, id, fields, useStoredProcedures)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the given DataRow.
        /// </summary>
        /// <param name="dr">The DataRow that contains the data to be loaded into the instance.</param>
        protected internal Customer(DataRow dr) : base(dr)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the given DataRow.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="dr">The DataRow that contains the data to be loaded into the instance.</param>
        protected internal Customer(LayerGenConnectionString connectionString, DataRow dr) : base(connectionString, dr)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the given DataRow. You can also specify if you want data access
        /// to be done with stored procedures or Sql text.
        /// </summary>
        /// <param name="dr">The DataRow that contains the data to be loaded into the instance.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        protected internal Customer(DataRow dr, bool useStoredProcedures) : base(dr, useStoredProcedures)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the given DataRow. You can also specify if you want data access
        /// to be done with stored procedures or Sql text.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="dr">The DataRow that contains the data to be loaded into the instance.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        protected internal Customer(LayerGenConnectionString connectionString, DataRow dr, bool useStoredProcedures) : base(connectionString, dr, useStoredProcedures)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, explicitly enabling
        /// or disabling the concurrency option.
        /// </summary>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        public Customer(ConcurrencyOptions concurrency) : base(concurrency)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, explicitly enabling
        /// or disabling the concurrency option.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        public Customer(LayerGenConnectionString connectionString, ConcurrencyOptions concurrency) : base(connectionString, concurrency)
        {
            
        }

		/// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, explicitly enabling
        /// or disabling the concurrency option. You can also specify if you want data access
        /// to be done with stored procedures or Sql text.
        /// </summary>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        public Customer(ConcurrencyOptions concurrency, bool useStoredProcedures) : base(concurrency, useStoredProcedures)
        {
            
        }

		/// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, explicitly enabling
        /// or disabling the concurrency option. You can also specify if you want data access
        /// to be done with stored procedures or Sql text.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        public Customer(LayerGenConnectionString connectionString, ConcurrencyOptions concurrency, bool useStoredProcedures) : base(connectionString, concurrency, useStoredProcedures)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and explicitly
        /// enabling or disabling the concurrency option.
        /// </summary>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        public Customer(int id, ConcurrencyOptions concurrency) : base(id, concurrency)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and explicitly
        /// enabling or disabling the concurrency option.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        public Customer(LayerGenConnectionString connectionString, int id, ConcurrencyOptions concurrency) : base(connectionString, id, concurrency)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and explicitly
        /// enabling or disabling the concurrency option. You can also specify if you want data
        /// access to be done with stored procedures or Sql text.
        /// </summary>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        public Customer(int id, ConcurrencyOptions concurrency, bool useStoredProcedures) : base(id, concurrency, useStoredProcedures)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and explicitly
        /// enabling or disabling the concurrency option. You can also specify if you want data
        /// access to be done with stored procedures or Sql text.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        public Customer(LayerGenConnectionString connectionString, int id, ConcurrencyOptions concurrency, bool useStoredProcedures) : base(connectionString, id, concurrency, useStoredProcedures)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and loading
        /// only the fields specified and explicitly enabling or disabling the
        /// concurrency option.
        /// </summary>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="fields">The list of <see cref="BusinessLayer.FooEnterprises.Customer.Fields"/> to pull from the database.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
		public Customer(int id, List<Fields> fields, ConcurrencyOptions concurrency) : base(id, fields, concurrency)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and loading
        /// only the fields specified and explicitly enabling or disabling the
        /// concurrency option.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="fields">The list of <see cref="BusinessLayer.FooEnterprises.Customer.Fields"/> to pull from the database.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
		public Customer(LayerGenConnectionString connectionString, int id, List<Fields> fields, ConcurrencyOptions concurrency) : base(connectionString, id, fields, concurrency)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and loading
        /// only the fields specified and explicitly enabling or disabling the
        /// concurrency option. You can also specify if you want data access to be
        /// done with stored procedures or Sql text.
        /// </summary>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="fields">The list of <see cref="BusinessLayer.FooEnterprises.Customer.Fields"/> to pull from the database.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
		public Customer(int id, List<Fields> fields, ConcurrencyOptions concurrency, bool useStoredProcedures) : base(id, fields, concurrency, useStoredProcedures)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the database that matches the given primary key and loading
        /// only the fields specified and explicitly enabling or disabling the
        /// concurrency option. You can also specify if you want data access to be
        /// done with stored procedures or Sql text.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="id">The primary key of the row that gets loaded from the database.</param>
        /// <param name="fields">The list of <see cref="BusinessLayer.FooEnterprises.Customer.Fields"/> to pull from the database.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
		public Customer(LayerGenConnectionString connectionString, int id, List<Fields> fields, ConcurrencyOptions concurrency, bool useStoredProcedures) : base(connectionString, id, fields, concurrency, useStoredProcedures)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the given DataRow and explicitly enabling or disabling the
        /// concurrency option.
        /// </summary>
        /// <param name="dr">The DataRow that contains the data to be loaded into the instance.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        protected internal Customer(DataRow dr, ConcurrencyOptions concurrency) : base(dr, concurrency)
        {

        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the given DataRow and explicitly enabling or disabling the
        /// concurrency option.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="dr">The DataRow that contains the data to be loaded into the instance.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        protected internal Customer(LayerGenConnectionString connectionString, DataRow dr, ConcurrencyOptions concurrency) : base(connectionString, dr, concurrency)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the given DataRow and explicitly enabling or disabling the
        /// concurrency option. You can also specify if you want data access to be
        /// done with stored procedures or Sql text.
        /// </summary>
        /// <param name="dr">The DataRow that contains the data to be loaded into the instance.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        protected internal Customer(DataRow dr, ConcurrencyOptions concurrency, bool useStoredProcedures) : base(dr, concurrency, useStoredProcedures)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class, loading a
        /// row from the given DataRow and explicitly enabling or disabling the
        /// concurrency option. You can also specify if you want data access to be
        /// done with stored procedures or Sql text.
        /// </summary>
        /// <param name="connectionString">Sets the connection string to use to connect to the database.</param>
        /// <param name="dr">The DataRow that contains the data to be loaded into the instance.</param>
        /// <param name="concurrency">A <see cref="BusinessLayer.FooEnterprises.Customer.ConcurrencyOptions"/> value indicating the level of concurrency.</param>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text.</param>
        protected internal Customer(LayerGenConnectionString connectionString, DataRow dr, ConcurrencyOptions concurrency, bool useStoredProcedures) : base(connectionString, dr, concurrency, useStoredProcedures)
        {

        }

        /// <summary>
        /// The name of the table
        /// </summary>
        public static string LgTableName
        {
            get { return LayerGenTableName; }
        }

        /// <summary>
        /// The name of table, delimited with brackets
        /// e.g. "[Customer]" instead of "Customer"
        /// </summary>
        public static string LgTableNameDelimited
        {
            get { return LayerGenTableNameDelimited; }
        }

        protected internal bool LayerGenIsUpdate()
        {
            return _layerGenIsUpdate;
        }

        protected internal string LayerGenConnectionString()
        {
            return _connectionString;
        }

        /// <summary>
        /// The name of the primary key in the table
        /// </summary>
        public static string LgPrimaryKeyName
        {
            get { return LayerGenPrimaryKey; }
        }


        /// <summary>
        /// Creates an instance of Customer from a JSON string
        /// </summary>
        /// <param name="json">The JSON string</param>
        /// <returns>A Customer object instance</returns>
        public static Customer FromJson(string json)
        {
            return JsonToCustomer(json);
        }

        /// <summary>
        /// Creates an instance of Customer from an XML string
        /// </summary>
        /// <param name="xml">The XML string</param>
        /// <returns>A Customer object instance</returns>
        public static Customer FromXml(string xml)
        {
            return XmlToCustomer(xml);
        }

        /// <summary>
        /// Creates an instance of Customer from a base64 encoded BSON string
        /// </summary>
        /// <param name="bson">The base64 encoded BSON string</param>
        /// <returns>A Customer object instance</returns>
        public static Customer FromBson(string bson)
        {
            return BsonToCustomer(bson);
        }

    }

    /// <summary>
    /// Represents a collection of <see cref="Customer"/> objects.
    /// </summary>
    [Serializable]
    public class Customers : List<Customer>
    {
        private string _connectionString;
        private readonly bool _useStoredProcedures;
        private readonly Customer.ConcurrencyOptions _concurrency;

        public Customers(Customer.ConcurrencyOptions concurrency)
        {
            _concurrency = concurrency;
            _useStoredProcedures = false;
            _connectionString = DataLayer.FooEnterprises.Universal.GetConnectionString();
		}

        public Customers(LayerGenConnectionString connectionString, Customer.ConcurrencyOptions concurrency)
        {
            _concurrency = concurrency;
            _useStoredProcedures = false;
            _connectionString = connectionString.ConnectionString;
		}

        public Customers(Customer.ConcurrencyOptions concurrency, bool useStoredProcedures)
        {
            _useStoredProcedures = useStoredProcedures;
            _concurrency = concurrency;
            _connectionString = DataLayer.FooEnterprises.Universal.GetConnectionString();
		}

        public Customers(LayerGenConnectionString connectionString, Customer.ConcurrencyOptions concurrency, bool useStoredProcedures)
        {
            _useStoredProcedures = useStoredProcedures;
            _concurrency = concurrency;
            _connectionString = connectionString.ConnectionString;
		}
		
        public Customers()
        {
            _concurrency = Customer.ConcurrencyOptions.Ignore;
            _useStoredProcedures = false;
            _connectionString = DataLayer.FooEnterprises.Universal.GetConnectionString();
		}

        public Customers(LayerGenConnectionString connectionString)
        {
            _concurrency = Customer.ConcurrencyOptions.Ignore;
            _useStoredProcedures = false;
            _connectionString = connectionString.ConnectionString;
		}

        public Customers(bool useStoredProcedures)
        {
            _concurrency = Customer.ConcurrencyOptions.Ignore;
            _useStoredProcedures = useStoredProcedures;
            _connectionString = DataLayer.FooEnterprises.Universal.GetConnectionString();
		}

        public Customers(LayerGenConnectionString connectionString, bool useStoredProcedures)
        {
            _concurrency = Customer.ConcurrencyOptions.Ignore;
            _useStoredProcedures = useStoredProcedures;
            _connectionString = connectionString.ConnectionString;
		}

        protected void Load(DataRowCollection dataRows)
        {
            Clear();
            LayerGenConnectionString connectString = new LayerGenConnectionString();
            connectString.ConnectionString = _connectionString;

            foreach (DataRow dr in dataRows)
            {
                Add(new Customer(connectString, dr, _concurrency, _useStoredProcedures));
            }
        }


        /// <summary>
        /// Retrieves rows from the Customer table by executing the given stored procedure.
        /// </summary>
        /// <param name="procedureName">The name of the stored procedure to execute.</param>
        /// <param name="procedureParams">A dictionary of parameter/value pairs. This can be null if there are no parameters.</param>
        public void GetByStoredProcedure(string procedureName, Dictionary<string, object> procedureParams)
        {
            LayerGenConnectionString connectString = new LayerGenConnectionString();
            connectString.ConnectionString = _connectionString;

            DataTable dt = DataLayer.FooEnterprises.Customer.GetByStoredProcedure(connectString, procedureName, procedureParams);
            if (dt != null)
            {
                Load(dt.Rows);
            }
        }

        /// <summary>
        /// Retrieves rows from the Customer table by executing the given stored procedure.
        /// </summary>
        /// <param name="procedureName">The name of the stored procedure to execute.</param>
        public void GetByStoredProcedure(string procedureName)
        {
            LayerGenConnectionString connectString = new LayerGenConnectionString();
            connectString.ConnectionString = _connectionString;

            DataTable dt = DataLayer.FooEnterprises.Customer.GetByStoredProcedure(connectString, procedureName, null);
            if (dt != null)
            {
                Load(dt.Rows);
            }
        }

        /// <summary>
        /// Retrieves rows from the Customer table, based on the given SQL statement.
        /// </summary>
        /// <param name="sql">The SQL statement to execute.</param>
        /// <param name="sqlParams">Optional <see cref="System.String.Format"/> like parameters</param>
        public void GetBySqlStatement(string sql, params object[] sqlParams)
        {
            LayerGenConnectionString connectString = new LayerGenConnectionString();
            connectString.ConnectionString = _connectionString;

            DataTable dt = DataLayer.FooEnterprises.Customer.GetBySqlStatement(connectString, sql, sqlParams);
            if (dt != null)
            {
                Load(dt.Rows);
            }
        }

        /// <summary>
        /// Retrieves all the rows from the Customer table.
        /// </summary>
        public void GetAll()
        {
		    GetAll(_useStoredProcedures);
        }

        /// <summary>
        /// Retrieves all the rows from the Customer table.
        /// </summary>
        /// <param name="useStoredProcedures">If true, then all data access will be done using stored procedures. Otherwise, data access will be done using Sql text</param>
        private void GetAll(bool useStoredProcedures)
        {
            LayerGenConnectionString connectString = new LayerGenConnectionString();
            connectString.ConnectionString = _connectionString;

            DataTable dt = DataLayer.FooEnterprises.Customer.GetAll(connectString, useStoredProcedures);
            if (dt != null)
            {
                Load(dt.Rows);
            }
        }
        /// <summary>
        /// Creates an instance of Customers from a base64 encoded BSON string
        /// </summary>
        /// <param name="bson">The base64 encoded BSON string</param>
        /// <returns>A Customers object instance</returns>
        public static Customers FromBson(string bson)
        {
            List<DataLayer.FooEnterprises.Customer.SerializableCustomer> zc;
            byte[] data = Convert.FromBase64String(bson);
            Customers tmp = new Customers();

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(data))
            {
                using (Newtonsoft.Json.Bson.BsonReader reader = new Newtonsoft.Json.Bson.BsonReader(ms))
                {
                    reader.ReadRootValueAsArray = true;
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    zc = serializer.Deserialize<List<DataLayer.FooEnterprises.Customer.SerializableCustomer>>(reader);
                }
            }

            foreach (DataLayer.FooEnterprises.Customer.SerializableCustomer z in zc)
            {
                tmp.Add(Customer.FromJson(Newtonsoft.Json.JsonConvert.SerializeObject(z)));
            }

            if (zc.Count > 0)
            {
                Encryption64 decryptor = new Encryption64();
                tmp._connectionString = decryptor.Decrypt(zc[0].SerializationConnectionString, DataLayer.FooEnterprises.Universal.LayerGenEncryptionKey);
            }

            return tmp;
        }

        /// <summary>
        /// Creates an instance of Customers from an XML string
        /// </summary>
        /// <param name="xml">The XML string</param>
        /// <returns>A Customers object instance</returns>
        public static Customers FromXml(string xml)
        {
            System.Xml.Serialization.XmlSerializer xType = new System.Xml.Serialization.XmlSerializer(typeof(List<DataLayer.FooEnterprises.Customer.SerializableCustomer>));
            List<DataLayer.FooEnterprises.Customer.SerializableCustomer> zc;
            Customers tmp = new Customers();

            using (System.IO.StringReader sr = new System.IO.StringReader(xml))
            {
                zc = (List<DataLayer.FooEnterprises.Customer.SerializableCustomer>)xType.Deserialize(sr);
            }

            foreach (DataLayer.FooEnterprises.Customer.SerializableCustomer z in zc)
            {
                tmp.Add(Customer.FromJson(Newtonsoft.Json.JsonConvert.SerializeObject(z)));
            }

            if (zc.Count > 0)
            {
                Encryption64 decryptor = new Encryption64();
                tmp._connectionString = decryptor.Decrypt(zc[0].SerializationConnectionString, DataLayer.FooEnterprises.Universal.LayerGenEncryptionKey);
            }

            return tmp;
        }

        /// <summary>
        /// Creates an instance of Customers from a JSON string
        /// </summary>
        /// <param name="json">The JSON string</param>
        /// <returns>A Customers object instance</returns>
        public static Customers FromJson(string json)
        {
            List<DataLayer.FooEnterprises.Customer.SerializableCustomer> zs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DataLayer.FooEnterprises.Customer.SerializableCustomer>>(json);
            Customers tmp = new Customers();

            foreach (DataLayer.FooEnterprises.Customer.SerializableCustomer z in zs)
            {
                tmp.Add(Customer.FromJson(Newtonsoft.Json.JsonConvert.SerializeObject(z)));
            }

            if (zs.Count > 0)
            {
                Encryption64 decryptor = new Encryption64();
                tmp._connectionString = decryptor.Decrypt(zs[0].SerializationConnectionString, DataLayer.FooEnterprises.Universal.LayerGenEncryptionKey);
            }

            return tmp;
        }

        /// <summary>
        /// Converts an instance of an object to a string format
        /// </summary>
        /// <param name="format">Specifies if it should convert to XML, BSON or JSON</param>
        /// <returns>The object, converted to a string representation</returns>
        public string ToString(SerializationFormats format)
        {
            Encryption64 encryptor = new Encryption64();
            List<DataLayer.FooEnterprises.Customer.SerializableCustomer> zs = new List<DataLayer.FooEnterprises.Customer.SerializableCustomer>();

            foreach (Customer z in this)
            {
                DataLayer.FooEnterprises.Customer.SerializableCustomer serializableCustomer = new DataLayer.FooEnterprises.Customer.SerializableCustomer();
                serializableCustomer.CustomerId = z.IsNull(Customer.Fields.CustomerId)
                    ? (int?) null : z.CustomerId;
                serializableCustomer.FirstName = z.IsNull(Customer.Fields.FirstName)
                    ? null : z.FirstName;
                serializableCustomer.LastName = z.IsNull(Customer.Fields.LastName)
                    ? null : z.LastName;
                serializableCustomer.SerializationIsUpdate = z.LayerGenIsUpdate();
                serializableCustomer.SerializationConnectionString = encryptor.Encrypt(z.LayerGenConnectionString(), DataLayer.FooEnterprises.Universal.LayerGenEncryptionKey);
                zs.Add(serializableCustomer);
            }
            
            if (format == SerializationFormats.Json)
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(zs);
            }

            if (format == SerializationFormats.Xml)
            {
                System.Xml.Serialization.XmlSerializer xType = new System.Xml.Serialization.XmlSerializer(zs.GetType());

                using (System.IO.StringWriter sw = new System.IO.StringWriter())
                {
                    xType.Serialize(sw, zs);
                    return sw.ToString();
                }
            }

            if (format == SerializationFormats.BsonBase64)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    using (Newtonsoft.Json.Bson.BsonWriter writer = new Newtonsoft.Json.Bson.BsonWriter(ms))
                    {
                        Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                        serializer.Serialize(writer, zs);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }

            return "";
        }

    }
}
