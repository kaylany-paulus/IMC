using System;

namespace Ideal_Weight
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            int numericName;
            decimal weightInKilos, heightInMeters;
            bool validWeightInKilos,validName, validHeight;

            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.WriteLine("\nSeja bem vindo(a) ao programa!");
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.DarkCyan;
            Console.Write("\nIremos calcular seu índice de Massa Corporal,"); 
            Console.Write(" juntamente com o seu peso ideal.");
            Console.ResetColor();

            Console.Write("\nMas antes por favor me diga seu nome..: ");
            username=(Console.ReadLine());
            validName= Int32.TryParse(username, out numericName);

                if (validName)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.DarkRed;
                    Console.WriteLine($"\n\n({numericName}) É UM NOME INVÁLIDO!\n");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }

            Console.Write($"\nDigite seu peso em kg...: ");
            validWeightInKilos= Decimal.TryParse(Console.ReadLine(), out weightInKilos);

                if (!validWeightInKilos)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.DarkRed;
                    Console.WriteLine(
                        "\n\nO VALOR DIGITADO NÃO CORRESPONDE A UM VALOR NUMÉRICO!\n");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }
            
            Console.Write("Digite sua altura em m..: ");
            validHeight=Decimal.TryParse(Console.ReadLine(), out heightInMeters);

                if (!validHeight)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.DarkRed;
                    Console.WriteLine(
                        "\n\nO VALOR DIGITADO NÃO CORRESPONDE A UM VALOR NUMÉRICO!\n");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }

                Console.Clear();

            decimal imc = weightInKilos / (heightInMeters * heightInMeters);

                if (imc < 17)
                {
                    Console.ForegroundColor=ConsoleColor.Yellow;
                    Console.WriteLine($"\n\nSeu IMC é = {imc:N2}");
                    Console.WriteLine("Diagnóstico: Muito abaixo do peso!");
                    Console.ResetColor();
                    Console.ForegroundColor=ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\nPor favor cuide-se!");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }

                else if(imc >= 17 && imc <= 18)
                {
                    Console.ForegroundColor=ConsoleColor.Yellow;
                    Console.WriteLine($"\n\nSeu IMC é = {imc:N2}");
                    Console.WriteLine("Diagnóstico: Abaixo do peso!");
                    Console.ResetColor();
                    Console.ForegroundColor=ConsoleColor.Yellow;
                    Console.WriteLine("\n\nPor favor cuide-se!");
                    Console.ResetColor();
                    Environment.Exit(-1);  
                }
                else if(imc >= 19 && imc <= 24)
                {
                    Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine($"\n\nSeu IMC é = {imc:N2}");
                    Console.WriteLine("Diagnóstico: Peso normal!");
                    Console.ResetColor();
                    Console.ForegroundColor=ConsoleColor.DarkGreen;
                    Console.WriteLine("\n\nPeso normal, mantenha-se assim!");
                    Console.ResetColor();
                    Environment.Exit(-1); 
                }
                else if(imc >= 25 && imc <= 29)
                {
                    Console.ForegroundColor=ConsoleColor.Yellow;
                    Console.WriteLine($"\n\nSeu IMC é= {imc:N2}");
                    Console.WriteLine("Diagnóstico: Acima do peso!");
                    Console.ForegroundColor=ConsoleColor.Yellow;
                    Console.WriteLine("\n\n!Por favor cuide-se!");
                    Console.ResetColor();
                    Environment.Exit(-1); 
                }

                else if(imc >= 30 && imc <= 34)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine($"\n\nSeu IMC é= {imc:N2}");
                    Console.WriteLine("Diagnóstico: Obesidade I !");
                    Console.ResetColor();
                    Console.ForegroundColor=ConsoleColor.DarkRed;
                    Console.WriteLine("\n\n!Por favor cuide-se!");
                    Console.ResetColor();
                    Environment.Exit(-1); 
                }
                else if(imc >= 35 && imc <= 39) 
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine($"\n\nSeu IMC é= {imc:N2}");
                    Console.WriteLine("Diagnóstico: Obesidade II (SEVERA)!");
                    Console.ResetColor();
                    Console.ForegroundColor=ConsoleColor.DarkRed;
                    Console.WriteLine("\n\n!Por favor cuide-se!");
                    Console.ResetColor();
                    Environment.Exit(-1); 
                }
                 else   
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine($"\n\nSeu IMC é = {imc:N2} kg");
                    Console.WriteLine("Diagnóstico: Obesidade III (Mórbida)");
                    Console.ResetColor();
                    Console.ForegroundColor=ConsoleColor.DarkRed;
                    Console.WriteLine("\n\n!Por favor cuide-se!");
                    Console.ResetColor();
                }

            Console.ResetColor();
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\n\nOBRIGADA POR ACESSAR O PROGRAMA!\n");
            Console.ResetColor();
            Environment.Exit(-1);
        }
    }
}
