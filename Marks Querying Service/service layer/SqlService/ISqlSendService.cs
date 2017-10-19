using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SqlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISqlSendService" in both code and config file together.
    [ServiceContract]
    public interface ISqlSendService
    {
        [OperationContract]
       
        void SendToSql(int student_roll, string student_name, int maths, int physics, int chemistry, int social, int english, int computers, string secondlang, int secondlang_marks, string if_passed);
        
    }
}
