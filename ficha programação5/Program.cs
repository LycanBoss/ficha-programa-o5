using System;

namespace ficha_programação5
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, numero3;
            Console.WriteLine("Informe seu ano de nascimento:");
            numero1 = float.Parse(Console.ReadLine());
            numero2 = 2021 - numero1;
            numero3 = 2022 - numero1;
            Console.WriteLine("Sua idade atual é:{0} anos", numero2);
            Console.WriteLine("Em 2022 voçê terá:{0} anos", numero3);
            Console.ReadLine();
        }
    }
}
