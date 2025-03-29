using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Basicos
{
    internal class Notifications
    {
        public void SendNottifications(List<string> list)
        {

            //TryCatch
            try
            {
                //ForEeach

                foreach (var item in list)
                {
                    var myNumber = Convert.ToInt32(item);
                    if (myNumber > 1)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                //log de erro
                throw new Exception("Erro");
            }
           

            //While

            //var count = 0;
            //while (count < list.Count)
            //{
            //    Console.WriteLine(list[count]);
            //    count++;
            //}
        }
    }
}
