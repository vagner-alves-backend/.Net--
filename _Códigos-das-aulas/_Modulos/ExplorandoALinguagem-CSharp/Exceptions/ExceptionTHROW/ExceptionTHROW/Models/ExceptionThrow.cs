using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionTHROW.Models
{
    public class ExceptionThrow
    {
        public void Modelo1()
        {
            try
            {
                Modelo2();
            }catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.WriteLine(", ocorreu uma exception.");
            }
        }

        public void Modelo2()
        {
            Modelo3();
        }

        public void Modelo3()
        {
            Modelo4();
        }

        public void Modelo4()
        {
            throw new Exception("Ocorreu um erro.");
        }
    }
}