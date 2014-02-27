using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    

        [OperationContract]
        Calc add(string op1, string op2);

        [OperationContract]
        Calc sub(string op1, string op2);


        [OperationContract]
        Calc mul(string op1, string op2);

        [OperationContract]
        Calc div(string op1, string op2);

        
    

	

	// TODO: Add your service operations here
}



