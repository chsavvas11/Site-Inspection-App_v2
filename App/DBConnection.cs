using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class DBConnection
    {
        // Private object of the class
        private static DBConnection _instance;

        // Connection string
        private string connectionString;

        // Connection to database
        private SqlConnection connectionToDB;

        /// <summary>
        /// constructor
        /// </summary>
        private DBConnection()
        {
            connectionString = Properties.Settings.Default.ConnectionString;

        }

        ///
        ///methods
        ///
        /**
         * Static method to return instance of database connection
         */
        public static DBConnection getInstanceOfDBConnection()
        {

            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        /**
         * Returns a data set built based on the query sent as parameter
         */
        public DataSet getDataSet(string sqlQuery)
        {
            // Create new dataset
            DataSet dataSet = new DataSet();

            using (connectionToDB = new SqlConnection(connectionString))
            {
                // Open the connection
                connectionToDB.Open();

                // Create the object dataAdapter to send a query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connectionToDB);

                // Fill in the dataset
                dataAdapter.Fill(dataSet);

            }

            return dataSet;

        }
    }
}
