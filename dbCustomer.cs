﻿using System.IO;
using System.Text.Json;
using System;
namespace Eclipse_Cofee_shop
{
    internal class dbCustomer
    {

        private string lastError = "";
        public Data data = new Data();
        private string tableName = "";
        private string directoryName = "";

        //
        // Constructor
        // ===========
        public dbCustomer()
        {
            // Automatically set a string to hold the path to the Database folder in the
            // correct bin/Debug folder for this project.
            directoryName = Directory.GetCurrentDirectory();

            // Set the name of the database table in the Database folder. It will
            // be a subdirectory of the Database folder located below the bin/Debug
            // folder for this project.
            tableName = "customer";
        }

        //
        // LastError 
        // =========
        // Returns the last error message generated by this class.
        //
        public string LastError
        {
            get { return lastError; }
        }

        //
        // Read
        // ====
        // Reads the specified record from the database table and unpacks the data in the
        // record if it is found. If the record is not found, all the database entries are
        // automaticall set blank so a new record can be created by the program if necessary.
        // 
        public Boolean Read(string ID)
        {
            lastError = "";
            Boolean found = false;
            Data newData = new Data();
            string json;

            if (directoryName.Trim() == "")
            {
                lastError = "Database directory name is blank.";
            }
            else if (tableName.Trim() == "")
            {
                lastError = "Table name is blank.";
            }
            else if (ID.Trim() == "")
            {
                lastError = "The record ID is blank";
            }
            else
            {
                // Open the JSON file, read to the end, and convert the JSON data to a single object
                // with named fields. This is called deserialising.
                try
                {
                    StreamReader reader = new StreamReader(directoryName + "\\Database\\" + tableName + "\\" + ID + ".txt")
                    {

                    };
                    json = reader.ReadToEnd();
                    reader.Close();

                    // The options variable sets up the parameters to make the DeSerialiszer 
                    // case insensitive.
                    var JsonOptions = new JsonSerializerOptions();
                    JsonOptions.PropertyNameCaseInsensitive = true;

                    data = JsonSerializer.Deserialize<Data>(json, JsonOptions);
                    found = true;

                }
                catch (Exception e)
                {
                    // the record was not found.
                    lastError = e.Message;
                    found = false;
                }
            }
            return found;
        }

        //
        // Update
        // ======
        // This function updates an existing customer or creates a new one.
        // Before calling this function, the calling form needs to update
        // each of the data fields.
        //
        public Boolean Update(string ID)
        {
            Boolean updated = false;
            string json = "";
            lastError = "";

            if (directoryName.Trim() == "")
            {
                lastError = "Database directory name is blank.";
            }
            else if (tableName.Trim() == "")
            {
                lastError = "Table name is blank.";
            }
            else if (ID.Trim() == "")
            {
                lastError = "The record ID is blank";
            }
            else
            {
                // The options variable sets up the parameters to make the Serialiszer 
                // format the JSON values indented on individual lines. They are easier
                // to read that way when the file is opened later in a text editor.
                var options = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };

                // Create the JSON format record for the table
                json = JsonSerializer.Serialize(data, options);

                // Write the record to the table
                try
                {
                    StreamWriter writer = new StreamWriter(directoryName + "\\Database\\" + tableName + "\\" + ID + ".txt");
                    writer.Write(json);
                    writer.Close();
                    updated = true;
                }
                catch (Exception e)
                {
                    // the record could not be written, but the catch stops the 
                    // system crashing.
                    lastError = "Could not write JSON text to the file. Error returned: \n\n" + e.Message;
                }
            }
            return updated;
        }
    }

    //
    // Data
    // ====
    // This is the internal class that provides access to each named field
    // stored in the JSON file. Other forms can access these fields by using
    // the method this class provides like this:
    //
    //     textBoxAddress.Text = customer.data.CustomerAddress; 
    // 
    // To add a new field to the table, create a new attribute with the correct
    // get and set methods to manage the new field. Declare the field at the
    // top of this class. The Read() and Update() methods will then automatically
    // process this new field. No changes should be required to the Read() or
    // Update() methods.
    //
    internal class Data
    {
        private string customerUsername;
        private string customerPassword;

        public string CustomerUsername
        {
            get { return customerUsername; }
            set { customerUsername = value; }
        }

        public string CustomerPassword
        {
            get { return customerPassword; }
            set { customerPassword = value; }
        }
    }
}