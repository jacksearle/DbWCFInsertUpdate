using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCF.ServiceReference1;

namespace TestWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();

            UserDetails user1 = new UserDetails();
            user1.ID = "010317";
            user1.FNAME = "row17";
            user1.SNAME = "hi";
            Console.WriteLine(client.InsertUserInformation(user1));

            UserDetails user2 = new UserDetails();
            user2.ID = "00";
            user2.FNAME = "AA";
            user2.SNAME = "BB";
            Console.WriteLine(client.UpdateUserInformation(user2));
            Console.ReadKey();

        

        }
    }
}
