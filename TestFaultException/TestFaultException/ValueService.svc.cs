using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestFaultException
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ValueService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ValueService.svc or ValueService.svc.cs at the Solution Explorer and start debugging.
    public class ValueService : IValueService
    {
        public string DoWork()
        {
            var x = new ErrorMessage() {
                Messages = "Bad day guru", FaultCode = "some code", NameSpace="asda//das/das", Source="evil source", Uri="http:"
            };

           throw new WebFaultException<ErrorMessage>(x,System.Net.HttpStatusCode.Conflict);
            return "pankaj at work";
        }
    }

    public class ErrorMessage
    {
        public string Source { get; set; }
        public string Messages { get; set; }
        public string Uri { get; set; }
        public string NameSpace { get; set; }
        public string FaultCode { get; set; }
    }
}
