using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int p;
            Console.WriteLine("qual programa deseja executar ?: ");
            p = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1:


                    int q = 1, prodn, prod, total = 0, quant = 0, valor = 0;

                    while (int i  = 0; q > 0; i++)
                    {
                        Console.WriteLine("Informe a quantidade de produtos");
                        prodn = int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o valor do produto");
                        prod = int.Parse(Console.ReadLine());

                        total = total + prod * prodn;
                        quant = quant * prodn;
                        Console.WriteLine("total: " + total);
                        Console.WriteLine("quantidade: " + prodn);
                    }

                    break;

                case 0:
                    int produtos = 0, maior = 0, menor = 0, t;
                    string parada, nome, nomeMaior, nomeMenor;

                    while {; parada != 1; }
                    {
                        Console.WriteLine("Digite o nome do produto: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("digite o valor do produto");
                        valor = int.Parse(Console.ReadLine());

                        float t = produtos * valor;
                        if (t > maior)
                        {
                            maior = (int)t;
                            nomeMaior = nome;
                        }
                        if (t < menor)
                        {
                            menor = (int)t;
                            nomeMenor = nome;
                        }

                        Console.WriteLine("deseja parar (S/N) ? :");
                        p = int.Parse(Console.ReadLine());
                        if (parada == "s")
                        {
                            break;
                        }
                    }
                    break;

                case 2:

                    Console.Write("Digite o número de avaliações: ");
                    int numAvaliacoes = int.Parse(Console.ReadLine());

                    double somaPesos = 0;

                    for (int i = 1; i <= numAvaliacoes; i++)
                    {
                        Console.Write($"Digite o peso da avaliação {i}: ");
                        double peso = double.Parse(Console.ReadLine());
                        somaPesos += peso;
                    }

                    if (somaPesos < 100)
                    {
                        Console.WriteLine($"A soma total dos pesos é insuficiente: {somaPesos}%");
                    }
                    else if (somaPesos > 100)
                    {
                        Console.WriteLine($"A soma total dos pesos é excedente: {somaPesos}%");
                    }
                    else
                    {
                        Console.WriteLine("A soma total dos pesos é adequada: 100%");
                        break;
                    }

                case 3:
                    Console.Write("Digite a sigla de um estado: ");
                    string sigla = Console.ReadLine().ToUpper();

                    string nomeCompleto;

                    switch (sigla)
                    {
                        case "AC":
                            nomeCompleto = "Acre";
                            break;
                        case "AL":
                            nomeCompleto = "Alagoas";
                            break;
                        case "AP":
                            nomeCompleto = "Amapá";
                            break;
                        case "AM":
                            nomeCompleto = "Amazonas";
                            break;
                        case "BA":
                            nomeCompleto = "Bahia";
                            break;
                        case "CE":
                            nomeCompleto = "Ceará";
                            break;
                        case "DF":
                            nomeCompleto = "Distrito Federal";
                            break;
                        case "ES":
                            nomeCompleto = "Espírito Santo";
                            break;
                        case "GO":
                            nomeCompleto = "Goiás";
                            break;
                        case "MA":
                            nomeCompleto = "Maranhão";
                            break;
                        case "MT":
                            nomeCompleto = "Mato Grosso";
                            break;
                        case "MS":
                            nomeCompleto = "Mato Grosso do Sul";
                            break;
                        case "MG":
                            nomeCompleto = "Minas Gerais";
                            break;
                        case "PA":
                            nomeCompleto = "Pará";
                            break;
                        case "PB":
                            nomeCompleto = "Paraíba";
                            break;
                        case "PR":
                            nomeCompleto = "Paraná";
                            break;
                        case "PE":
                            nomeCompleto = "Pernambuco";
                            break;
                        case "PI":
                            nomeCompleto = "Piauí";
                            break;
                        case "RJ":
                            nomeCompleto = "Rio de Janeiro";
                            break;
                        case "RN":
                            nomeCompleto = "Rio Grande do Norte";
                            break;
                        case "RS":
                            nomeCompleto = "Rio Grande do Sul";
                            break;
                        case "RO":
                            nomeCompleto = "Rondônia";
                            break;
                        case "RR":
                            nomeCompleto = "Roraima";
                            break;
                        case "SC":
                            nomeCompleto = "Santa Catarina";
                            break;
                        case "SP":
                            nomeCompleto = "São Paulo";
                            break;
                        case "SE":
                            nomeCompleto = "Sergipe";
                            break;
                        case "TO":
                            nomeCompleto = "Tocantins";
                            break;
                        default:
                            nomeCompleto = "";
                            break;
                    }

                    if (nomeCompleto == "")
                    {
                        Console.WriteLine("Sigla de estado inválida!");
                    }
                    else
                    {
                        Console.WriteLine($"O estado correspondente à sigla {sigla} é {nomeCompleto}.");
                    }
                    break;

                case 4:
                    Console.Write("Digite um número inteiro entre 1 e 12: ");
                    int mes = int.Parse(Console.ReadLine());

                    switch (mes)
                    {
                        case 1:
                        case 2:
                        case 12:
                            Console.WriteLine("Estação do ano: Verão");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("Estação do ano: Outono");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Estação do ano: Inverno");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("Estação do ano: Primavera");
                            break;
                        default:
                            Console.Write("Mês inválido. ");

                            if (mes < 1 || mes > 12)
                            {
                                Console.WriteLine("Número fora do intervalo permitido.");
                            }
                            else
                            {
                                Console.WriteLine("Esse mês corresponde a duas estações. Digite \"1\" para Primavera/Verão ou \"2\" para Outono/Inverno.");
                                int estacao = int.Parse(Console.ReadLine());

                                switch (estacao)
                                {
                                    case 1:
                                        Console.WriteLine("Estação do ano: Verão");
                                        break;
                                    case 2:
                                        Console.WriteLine("Estação do ano: Inverno");
                                        break;
                                    default:
                                        Console.WriteLine("Opção inválida.");
                                        break;
                                }
                            }
                            break;
                            break;

                        case 5:


                            Console.Write("Informe o seu peso em kg: ");
                            double peso = double.Parse(Console.ReadLine());

                            Console.Write("Informe a sua altura em metros: ");
                            double altura = double.Parse(Console.ReadLine());

                            double imc = peso / (altura * altura);

                            Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

                            if (imc < 18.5)
                            {
                                Console.WriteLine("Você está abaixo do peso.");
                            }
                            else if (imc >= 18.5 && imc <= 24.9)
                            {
                                Console.WriteLine("Você está com peso normal.");
                            }
                            else if (imc >= 25.0 && imc <= 29.9)
                            {
                                Console.WriteLine("Você está com sobrepeso.");
                            }
                            else if (imc >= 30.0 && imc <= 34.9)
                            {
                                Console.WriteLine("Você está com obesidade grau 1.");
                            }
                            else if (imc >= 35.0 && imc <= 39.9)
                            {
                                Console.WriteLine("Você está com obesidade grau 2.");
                            }
                            else
                            {
                                Console.WriteLine("Você está com obesidade grau 3 (mórbida).");
                                break;
                            }

                        case 6:

                            Console.Write("Digite um número inteiro positivo: ");
                            int n = int.Parse(Console.ReadLine());

                            Console.WriteLine("Divisores de " + n + ":");

                            for (int i = 1; i <= n; i++)
                            {
                                if (n % i == 0)
                                {
                                    Console.WriteLine(i);


                                }
                            }
                            break;
                    }
            }
        }














    }








}