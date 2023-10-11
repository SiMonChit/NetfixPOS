using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Common
{
    public class AppConfiguration
    {
        private static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private static ConnectionStringSettings Connection;
        private static ConnectionStringSettingsCollection connections;
        public static void AddConfiguration(string Name, string ProviderName, string ConnectionString)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                ConnectionStringsSection connectionStrings = config.ConnectionStrings;

                // Clear existing connection strings
                connectionStrings.ConnectionStrings.Clear();

                // If the connection string with the same name exists, delete it
                if (connectionStrings.ConnectionStrings[Name] != null)
                {
                    connectionStrings.ConnectionStrings.Remove(Name);
                }

                // Create a new connection string
                ConnectionStringSettings newConnection = new ConnectionStringSettings();
                newConnection.Name = "MainDB"; // Replace with your desired name
                newConnection.ProviderName = ProviderName;
                newConnection.ConnectionString = ConnectionString;

                // Add the new connection string to the collection
                connectionStrings.ConnectionStrings.Add(newConnection);
                config.Save(ConfigurationSaveMode.Full);
            }
            catch (ConfigurationErrorsException ex)
            {
                // Handle configuration errors
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static string ReadConnectionString()
        {
            string _Name = "";

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (config.HasFile)
                {
                    ConnectionStringsSection connectionStrings = config.ConnectionStrings;

                    foreach (ConnectionStringSettings connection in connectionStrings.ConnectionStrings)
                    {
                        _Name = connection.ConnectionString;
                    }
                }
            }
            catch (ConfigurationErrorsException ex)
            {
                // Handle configuration errors
                Console.WriteLine("Error: " + ex.Message);
            }

            return _Name;
        }

        public static string ReadProviderName()
        {
            string _Name = "";

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (config.HasFile)
                {
                    ConnectionStringsSection connectionStrings = config.ConnectionStrings;

                    foreach (ConnectionStringSettings connection in connectionStrings.ConnectionStrings)
                    {
                        _Name = connection.ProviderName;
                    }
                }
            }
            catch (ConfigurationErrorsException ex)
            {
                // Handle configuration errors
                Console.WriteLine("Error: " + ex.Message);
            }

            return _Name;
        }

        public static void EncryptConfiguration()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSection sect = config.GetSection("connectionStrings");

            if (sect != null)
            {
                if (!sect.SectionInformation.IsProtected)
                {
                    sect.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    sect.SectionInformation.ForceSave = true;
                    config.Save(ConfigurationSaveMode.Full);
                }
            }
        }

        public static void DecryptConfiguration()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSection sect = config.GetSection("connectionStrings");

            if (sect != null)
            {
                if (sect.SectionInformation.IsProtected)
                {
                    sect.SectionInformation.UnprotectSection();
                    sect.SectionInformation.ForceSave = true;
                    config.Save(ConfigurationSaveMode.Full);
                }
            }
        }

        public static void DeleteConfiguration(ConnectionStringSettings name)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection connectionStrings = config.ConnectionStrings;

            // Remove the specified connection string
            if (connectionStrings.ConnectionStrings[name.Name] != null)
            {
                connectionStrings.ConnectionStrings.Remove(name.Name);
                config.Save(ConfigurationSaveMode.Full);
            }
        }
    }
}
