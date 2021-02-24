using SecureLine.Data_Access;
using System.Configuration;

namespace SecureLine
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        //Improves maintainability. This makes it easier to add new data connections (e.g. saving to a textfile) in future.
        //You only need to add another bool and then create the connection.
        public static void InitaliseConnection(bool database)
        {
            if (database)
            {
                //Create the SQL connection
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
        }

        /// <summary>
        /// Looks up which connection string to get out of 'App.Config' and returns it
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Connection string</returns>
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        /// <summary>
        /// Looks up the sender e-mail address from 'App.Config' and returns it
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Sender e-mail string</returns>
        public static string AppKeyLookup(string key)
        {
            return ConfigurationManager.AppSettings[key];
            //secureline.secureline@gmail.com
        }
    }
}
