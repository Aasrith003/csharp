﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace client_weBsite.SqlSendData {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SqlSendData.ISqlSendService")]
    public interface ISqlSendService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISqlSendService/SendToSql", ReplyAction="http://tempuri.org/ISqlSendService/SendToSqlResponse")]
        void SendToSql(int student_roll, string student_name, int maths, int physics, int chemistry, int social, int english, int computers, string secondlang, int secondlang_marks, string if_passed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISqlSendService/SendToSql", ReplyAction="http://tempuri.org/ISqlSendService/SendToSqlResponse")]
        System.Threading.Tasks.Task SendToSqlAsync(int student_roll, string student_name, int maths, int physics, int chemistry, int social, int english, int computers, string secondlang, int secondlang_marks, string if_passed);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISqlSendServiceChannel : client_weBsite.SqlSendData.ISqlSendService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SqlSendServiceClient : System.ServiceModel.ClientBase<client_weBsite.SqlSendData.ISqlSendService>, client_weBsite.SqlSendData.ISqlSendService {
        
        public SqlSendServiceClient() {
        }
        
        public SqlSendServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SqlSendServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SqlSendServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SqlSendServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendToSql(int student_roll, string student_name, int maths, int physics, int chemistry, int social, int english, int computers, string secondlang, int secondlang_marks, string if_passed) {
            base.Channel.SendToSql(student_roll, student_name, maths, physics, chemistry, social, english, computers, secondlang, secondlang_marks, if_passed);
        }
        
        public System.Threading.Tasks.Task SendToSqlAsync(int student_roll, string student_name, int maths, int physics, int chemistry, int social, int english, int computers, string secondlang, int secondlang_marks, string if_passed) {
            return base.Channel.SendToSqlAsync(student_roll, student_name, maths, physics, chemistry, social, english, computers, secondlang, secondlang_marks, if_passed);
        }
    }
}
