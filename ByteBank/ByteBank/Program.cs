using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoDiego = new ContaCorrente();
            contaDoDiego.titular = "Diego";
            contaDoDiego.agencia = 863;
            contaDoDiego.numero = 863452;
            contaDoDiego.saldo = 100;

            Console.WriteLine(contaDoDiego.titular);
            Console.WriteLine("Agência: " + contaDoDiego.agencia);
            Console.WriteLine("Número: " + contaDoDiego.numero);
            Console.WriteLine("Saldo: " + contaDoDiego.saldo);
        }
    }
}
