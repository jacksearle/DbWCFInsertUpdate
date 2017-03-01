using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DbWCFInsertUpdate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string InsertUserInformation(UserDetails userInfo);

        [OperationContract]
        string UpdateUserInformation(UserDetails userInfo);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class UserDetails
    {
        string id;
        string fname;
        string sname;

        [DataMember]
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string FNAME
        {
            get { return fname; }
            set { fname = value; }
        }

        [DataMember]
        public string SNAME
        {
            get { return sname; }
            set { sname = value; }
        }
    }
}
