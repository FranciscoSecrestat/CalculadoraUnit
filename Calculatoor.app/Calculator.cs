

using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace Calculatoor.app
{
    public class CalculatorSystem
    {
        
        public int Sum(string nums) 
        {
            if(string.IsNullOrEmpty(nums))
               return 0;

            return nums.Split(',', ';', '|')
                .Select(int.Parse)
                .Sum();

        }

        public int NumerosNegativos(string nums)
        {
            var numerosNegativos = int.Parse(nums);

            if (numerosNegativos < 0)

                throw new Exception("no");

            return numerosNegativos;
        }

        public int NumerosMayorACien(string nums) 
        { 
            
            var nemrosMayorACien = int.Parse(nums);

            if(nemrosMayorACien <= 100)

                    throw new Exception("no");  
            return nemrosMayorACien;

            
        }

        

    }
}
