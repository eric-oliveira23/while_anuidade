using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_anuidade
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double anuidade, material, matricula, totalm, total;
                string resp;

                do
                {
                    Console.Write("Digite o valor da anuidade: R$");
                    anuidade = int.Parse(Console.ReadLine());

                    while (anuidade <= 0)
                    {
                        Console.Write("Valor digitado inválido.");

                        Console.WriteLine("Digite o valor da anuidade: R$");
                        anuidade = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Digite o valor da matrícula: R$");
                    matricula = int.Parse(Console.ReadLine());

                    while (matricula <= 0)
                    {
                        Console.Write("Valor digitado inválido. ");

                        Console.Write("Digite o valor da matrícula: R$");
                        matricula = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Digite o valor do material: R$");
                    material = int.Parse(Console.ReadLine());

                    while (anuidade <= 0)
                    {
                        Console.Write("Valor digitado inválido.");

                        Console.Write("Digite o valor do material: R$");
                        material = int.Parse(Console.ReadLine());
                    }

                    totalm = anuidade / 12 + matricula + material;
                    Console.WriteLine("O valor da primeira parcela (Com matrícula e materiais) será de: " + totalm.ToString("C"));

                    total = anuidade / 12;
                    Console.WriteLine("O valor da primeira parcela será de: " + total.ToString("C"));

                    Console.WriteLine("Deseja repetir o processo?");
                    resp = Console.ReadLine().ToUpper();

                }
                while (resp == "S" || resp == "SIM");
            }





            catch (FormatException)
            {
                Console.WriteLine("Caractere digitado fora do contexto atual.");
            }

            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro, tente novamente mais tarde.");
            }

            Console.ReadKey();


            } 
        }
    }
