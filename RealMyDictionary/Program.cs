using System;

namespace RealMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();

            //Dictionary dictionary1 = new Dictionary();
            //dictionary1.CustomerId = 1;
            //dictionary1.Name = "mustafa";
            //dictionary1.LastName = "Kutlu";

            //Dictionary dictionary2 = new Dictionary();
            //dictionary2.CustomerId = 2;
            //dictionary2.Name = "Cemil";
            //dictionary2.LastName = "Meriç";

            //Dictionary dictionary3 = new Dictionary();
            //dictionary3.CustomerId = 3;
            //dictionary3.Name = "Ahmet h.";
            //dictionary3.LastName = "Tanpınar";

            //MyDictionary<string> isimler = new MyDictionary<string> ();


            isimler.Add("cahit zarifoğlu");
            isimler.Add("Kemal Özer");
            

        }
    }
}
