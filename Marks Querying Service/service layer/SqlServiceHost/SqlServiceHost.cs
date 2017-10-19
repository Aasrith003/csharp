using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.ServiceModel;

namespace SqlServiceHost
{
    class SqlServiceHost
    {
        static void Main()
        {
            ServiceHost host = new ServiceHost(typeof(SqlService.SqlService));
            ServiceHost host2 = new ServiceHost(typeof(SqlService.SqlSendService));
            
               try
               {
                   host.Open();
                   host2.Open();
                   
                   Console.Write("services have started @" + DateTime.Now);
                   Console.ReadLine();

               }
                catch(Exception ex)
               {
                   Console.WriteLine(ex.Message);
               }
           
        }
    }
}
