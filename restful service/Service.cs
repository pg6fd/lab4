using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;
using System.Web.Script.Serialization;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.


public class Service : IService

{
    [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "add/{op1}/{op2}")]
	public Calc add(string op1,string op2)
    {
        return new Calc()
        {
            result = Double.Parse(op1) + Double.Parse(op2)
        };


    }

    [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "sub/{op1}/{op2}")]
    public Calc sub(string op1, string op2)
    {
        return new Calc()
        {
            result = Double.Parse(op1) - Double.Parse(op2)
        };


    }

    [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "mul/{op1}/{op2}")]
    public Calc mul(string op1, string op2)
    {
        return new Calc()
        {
            result = Double.Parse(op1) * Double.Parse(op2)
        };


    }

    [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "div/{op1}/{op2}")]
    public Calc div(string op1, string op2)
    {
        int denominator = Int32.Parse(op2);
        if (denominator == 0)
            return new Calc()
            {

                ex = "Denominator cannot be zero"
            };

        else
            return new Calc()
        {
            result = Double.Parse(op1) / Double.Parse(op2)
        };
    }


   
    


    

    
    

 }
