using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace SqlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISqlService" in both code and config file together.
    [ServiceContract]
    public interface ISqlService
    {
        [OperationContract]
        DataSet Get_Data(string dbname , int rollno);
    }

}
