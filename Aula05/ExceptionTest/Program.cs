using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere um numero inteiro: ");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero inserido: {i}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Numero demasiado grande");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato Incorreto");
            }
            finally
            {
                Console.WriteLine("Obrigado por desperdicar tempo a ler isto.");
            }
        }
    }
}
