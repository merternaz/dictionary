using System;
using System.Collections.Generic;

namespace dictEx
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<int,string> malzemeler=new Dictionary<int, string>();
            Dictionary<int,float> fiyat=new Dictionary<int, float>();
            Dictionary<string,float> kur=new Dictionary<string, float>();

            malzemeler.Add(1,"kalem");
            fiyat.Add(1,3.5f);
            malzemeler.Add(2,"silgi");
            fiyat.Add(2,5f);
            malzemeler.Add(3,"defter");
            fiyat.Add(3,10.25f);
            int counter=0;
            foreach(var x in malzemeler)
            {
                Console.WriteLine(x+","+counter.ToString());
                counter++;
            }

            foreach(var x in malzemeler)
            {
                foreach(var y in fiyat)
                {
                    if(x.Key==y.Key){
                        Console.WriteLine(x.Value+"="+y.Value);
                    }
                }
                
            }




        }
    }
}