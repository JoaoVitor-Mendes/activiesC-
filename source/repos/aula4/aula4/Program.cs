using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {

            EmailService.EnviarEmail(new Pessoa("000000", "Joao", "jcartapati@gmail.com"));

           

            Console.ReadLine();

         

        }


    }

}


