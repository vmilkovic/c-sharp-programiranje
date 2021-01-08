using System.Collections.Generic;
using System.Xml;

namespace Notes {
    static class Database {
        
        public static string DatabaseConnectionString() {
            return string.Format(
                "Data Source = {0}; Initial Catalog = {1}; User ID = {2}; Password = {3}",
                LoadDatabaseConfig().ToArray());
        }

        public static List<string> LoadDatabaseConfig() {

            List<string> configData = new List<string>();

            XmlDocument xmlConfig = new XmlDocument();
            xmlConfig.Load("../../../config.xml");
                
            foreach(XmlNode data in xmlConfig.SelectSingleNode("Database").ChildNodes) {
                configData.Add(data.InnerText);
            }

            return configData;

        }

    }
}
