using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>(); 
    }
    public static void InitializeConnections(bool database, bool textFiles)
    {
        
        if (database)
        {
            //TODO - Create the SQL connection
            SQLConnector sql = new SQLConnector();
            Connections.Add(sql);
        }
        if (textFiles)
        {
            //TODO - Create the Text connection
            TextConnection text = new TextConnection();
            Connections.Add(text);
        }

    }
}
