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

        /**
         * Method that saves new user into the database
         */
        public void createNewUser(string sqlQuery, string username, string password, string accessLevel, string firstName, string lastName)
        {
            using (SqlConnection connectionToDB = new SqlConnection(connectionString))
            {
                // Open the connection
                connectionToDB.Open();

                // Create SqlCommand
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionToDB);

                // Set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                // Add the parameters to the command
                sqlCommand.Parameters.Add(new SqlParameter("username", username));
                sqlCommand.Parameters.Add(new SqlParameter("password", password));
                sqlCommand.Parameters.Add(new SqlParameter("access_level", accessLevel));
                sqlCommand.Parameters.Add(new SqlParameter("first_name", firstName));
                sqlCommand.Parameters.Add(new SqlParameter("last_name", lastName));

                // Execute the command
                sqlCommand.ExecuteNonQuery();

                // Close the connection
                connectionToDB.Close();
            }

        }

        public void createInspection(string sqlQuery, InspectionInformationData newInspectionInformation)
        {
            using (SqlConnection connectionToDB = new SqlConnection(connectionString))
            {
                // Open the connection
                connectionToDB.Open();

                // Create SqlCommand
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionToDB);

                // Set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                // Add the parameters to the command
                //sqlCommand.Parameters.Add(new SqlParameter("username", username));
                sqlCommand.Parameters.Add(new SqlParameter("site", newInspectionInformation.site));
                sqlCommand.Parameters.Add(new SqlParameter("work_area", newInspectionInformation.workArea));
                sqlCommand.Parameters.Add(new SqlParameter("supervisor", newInspectionInformation.supervisor));
                sqlCommand.Parameters.Add(new SqlParameter("completed_by", newInspectionInformation.completedBy));
                sqlCommand.Parameters.Add(new SqlParameter("job_description", newInspectionInformation.jobDescription));
                sqlCommand.Parameters.Add(new SqlParameter("inspector_name", newInspectionInformation.inspector));
                sqlCommand.Parameters.Add(new SqlParameter("date", newInspectionInformation.date));
                sqlCommand.Parameters.Add(new SqlParameter("type", newInspectionInformation.type));
                // Execute the command
                sqlCommand.ExecuteNonQuery();

                // Close the connection
                connectionToDB.Close();
            }
        }

        public void createInspectionChecks(string sqlQuery, CheckData[] newCheckDataArray)
        {
            using (SqlConnection connectionToDB = new SqlConnection(connectionString))
            {
                // Open the connection
                connectionToDB.Open();

                //sqlCommand.Parameters.Add(new SqlParameter("username", username));
                foreach (CheckData checkData in newCheckDataArray)
                {
                    // Create SqlCommand
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectionToDB);

                    // Set the sqlCommand's properties
                    sqlCommand.CommandType = CommandType.Text;

                    // Add the parameters to the command
                    sqlCommand.Parameters.Add(new SqlParameter("check_number", checkData.checkNumber));
                    sqlCommand.Parameters.Add(new SqlParameter("negative_interventions", checkData.negativeInterventionAmount));
                    sqlCommand.Parameters.Add(new SqlParameter("negative_comments", checkData.negativeInterventionComments));
                    sqlCommand.Parameters.Add(new SqlParameter("positive_interventions", checkData.positiveInterventionAmount));
                    sqlCommand.Parameters.Add(new SqlParameter("positive_comments", checkData.positiveInterventionComments));
                    sqlCommand.Parameters.Add(new SqlParameter("is_completed", checkData.isCompleted));

                    // Execute the command
                    sqlCommand.ExecuteNonQuery();
                }

                // Close the connection
                connectionToDB.Close();
            }
        }
    }
}
