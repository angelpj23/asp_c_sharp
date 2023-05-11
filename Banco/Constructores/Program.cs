using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando el contructor con un argumento
            CuentaBancaria cuenta1 = new CuentaBancaria("000001", "Haraka", 1000000);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", 
                cuenta1.NoCuenta, cuenta1.Usuario, cuenta1.Saldo);

            // Usando el contructor con dos argumentos
            CuentaBancaria cuenta2 = new CuentaBancaria("000002", "Angel Perez", 5800);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", 
                cuenta2.NoCuenta, cuenta2.Usuario, cuenta2.Saldo);

            // Usando el contructor con tres argumentos
            CuentaBancaria cuenta3 = new CuentaBancaria("000003", "Jane Doe", 10000);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", 
                cuenta3.NoCuenta, cuenta3.Usuario, cuenta3.Saldo);

            CuentaBancaria cuenta4 = new CuentaBancaria();
            Console.ReadKey();
        }
        
    }
}
