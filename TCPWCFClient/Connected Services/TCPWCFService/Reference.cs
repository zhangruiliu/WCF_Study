﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCPWCFClient.TCPWCFService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TCPWCFService.ITCPTeachService")]
    public interface ITCPTeachService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITCPTeachService/GetServerName", ReplyAction="http://tempuri.org/ITCPTeachService/GetServerNameResponse")]
        string GetServerName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITCPTeachService/GetServerName", ReplyAction="http://tempuri.org/ITCPTeachService/GetServerNameResponse")]
        System.Threading.Tasks.Task<string> GetServerNameAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITCPTeachServiceChannel : TCPWCFClient.TCPWCFService.ITCPTeachService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TCPTeachServiceClient : System.ServiceModel.ClientBase<TCPWCFClient.TCPWCFService.ITCPTeachService>, TCPWCFClient.TCPWCFService.ITCPTeachService {
        
        public TCPTeachServiceClient() {
        }
        
        public TCPTeachServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TCPTeachServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TCPTeachServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TCPTeachServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetServerName() {
            return base.Channel.GetServerName();
        }
        
        public System.Threading.Tasks.Task<string> GetServerNameAsync() {
            return base.Channel.GetServerNameAsync();
        }
    }
}
