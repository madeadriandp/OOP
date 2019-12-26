using System.Security.Authentication;
using System;

namespace oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("secretMD5: " + Hash.md5("secret"));
            // Console.WriteLine("secretSHA1: " + Hash.SHA1("secret"));
            // Console.WriteLine("secret256: " + Hash.sha256("secret"));
            // Console.WriteLine("secret512: " + Hash.sha512("secret"));
            // Console.WriteLine(Cipher.Encrypt("Ini tulisan rahasia", "p4$$w0rd"));
            // Console.WriteLine(Cipher.Decrypt("/zxhplxUH5tBL53t1SujBprtcQvzbiJJm2pxWRsdyxALf3tSxEi74xbT7bbK1Vsv", "p4$$w0rd"));
           
//             LogWriter.WriteLog(@"[2018-04-03T12:10:36.100Z] INFO: This is an information about something.
// [2018-04-03T13:21:36.201Z] ERROR: We can't divide any numbers by zero.
// [2018-04-03T16:45:36.210Z] NOTICE: Someone loves your status.
// [2018-04-03T23:40:36.215Z] WARNING: Insufficient funds.
// [2018-04-03T23:56:36.215Z] DEBUG: This is debug message.
// [2018-04-04T04:54:36.102Z] ALERT: Achtung! Achtung!
// [2018-04-04T05:01:36.103Z] CRITICAL: Medic!! We've got critical damages.
// [2018-04-04T05:05:36.104Z] EMERGENCY: System hung. Contact system administrator immediately!");

                Order order =new Order();

                order.addItem(1, 2000, 2).addItem(2, 3000, 3).addItem(3, 4000, 10);
                
                order.showAll();
                order.checkout();
                

            


        }
    }
}
