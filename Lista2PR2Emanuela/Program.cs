using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2Emanuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade 1

            //double l,p1,p2;

            //Console.WriteLine("Digite a quantidade de Laranjas: ");
            //l = double.Parse(Console.ReadLine());  //Lê o numero

            //if (l < 12)
            //{
            //    p1 = l * 0.35;
            //    Console.WriteLine("O preço das laranjas fica: " + p1);

            //}else{


            //        p2 = l * 0.28;
            //    Console.WriteLine("O preço das laranjas fica: " + p2);

            //}

            //Console.ReadKey();  //tela preta

            //---------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 2

           // int ano;

           // Console.WriteLine("digite o ano do seu nascimento: ");
           // ano = int.Parse(Console.ReadLine());  //lê o numero


           // if (ano <= 2007 )

           // Console.WriteLine("você pode votar ");

           // else

            // Console.WriteLine("você não pode votar");
             //Console.ReadKey();  //tela preta

            //-------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 3

            //float tri1, tri2, tri3;

            //Console.WriteLine("Digite o lado 1 do seu triângulo: ");
            //tri1 = float.Parse(Console.ReadLine());  //Lê o numero

            //Console.WriteLine("Digite o lado 2 do seu triângulo: ");
            //tri2 = float.Parse(Console.ReadLine());  //Lê o numero

            //Console.WriteLine("Digite o lado 3 do seu triângulo: ");
            //tri3 = float.Parse(Console.ReadLine());  //Lê o numero

            //if (tri1 == tri2 && tri2 == tri3 && tri3 == tri1)
            //    Console.WriteLine("Este triangulo é equilátero");

            //else if(tri1 != tri2 && tri2 != tri3 && tri3 != tri1)
            //     Console.WriteLine("Este triangulo é escaleno");

            //else 
            //    Console.WriteLine("este triangulo é isosceles");
            //Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 4

            //float a, b, c, quadrado,delta,raiz1,raiz2;


            //Console.WriteLine("Digite o valor de a: ");
            //a = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor de b: ");
            //b = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor de c: ");
            //c = float.Parse(Console.ReadLine());

            //quadrado = b * b;

            //delta = quadrado - 4 * a * c;

            //if(delta == 0)
              //  Console.WriteLine("Não tem raiz");

            //else if (delta > 0)
                //Console.WriteLine("Tem raiz");

            //else
                //Console.WriteLine("Tem duas raizes");

            //raiz1 =(float) (-b + Math.Sqrt(delta) )/ (2 * a);
            //raiz2 =(float) (-b - Math.Sqrt(delta)) / (2 * a);

            //Console.WriteLine("A raíz 1 é: " + raiz1);
            //Console.WriteLine("A raíz 2 é: " + raiz2);

            //Console.ReadKey();

            //---------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 5

             //int num;

           // Console.WriteLine("Digite um número inteiro ");
            // num = int.Parse(Console.ReadLine());

             //if ((num % 3) == 0) { 
           //  Console.WriteLine("Seu número é divisel por 3");

           //  }  else if ((num % 5) == 0) { 
           //  Console.WriteLine("Seu número é divisel por 5");

            // } if((num % 3) == 0) && ((num % 5) == 0){ 
            //        Console.WriteLine("Seu número é divisivel por ambos");

             //} else { 
             //   Console.WriteLine("Seu numero nao e divisel nem por 3 e nem por 5");
            // }

               //Console.ReadKey();


            //---------------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 6

            //float ang1, ang2, ang3;

          //Console.WriteLine("Digite angulo 1 do seu triângulo: ");
           //ang1 = float.Parse(Console.ReadLine());  //Lê o numero

            //Console.WriteLine("Digite o angulo 2 do seu triângulo: ");
           // ang2 = float.Parse(Console.ReadLine());  //Lê o numero

           // Console.WriteLine("Digite o angulo 3 do seu triângulo: ");
           // ang3 = float.Parse(Console.ReadLine());  //Lê o numero

           // if ((ang1 == 90) || (ang2 == 90) || (ang3 == 90))
           //      Console.WriteLine("Seu triângulo é um triângulo retângulo ");

           // else if ((ang1 > 90) || (ang2 > 90) || (ang3 > 90))
           //    Console.WriteLine("Seu triângulo é um triângulo obtusângulo ");
             
          //  else
           //    Console.WriteLine("É um triângulo de três ângulos agudos");


          //  Console.ReadKey();

            //----------------------------------------------------------------------------------------------------------------------------------------

            //Atividade 7

            //int a, b, c;

           // Console.WriteLine("qual o valor do numero ");
            //a = int.Parse(Console.ReadLine());
           
           // Console.WriteLine("qual o valor do numero ");
           // b = int.Parse(Console.ReadLine());
           
            //Console.WriteLine("qual o valor do numero ");
           // c = int.Parse(Console.ReadLine());

            //if (a < b && b < c) 
             //  Console.WriteLine(a +" "+ b+" " + c);

           // else if (a < b  && b > c)
              // Console.WriteLine(a + " " + c + " "+b);
           
           // else if (b < a  && a < c)
              // Console.WriteLine(b + " " + a + " "+c);
            
          //  else if (b < a  && a > c)
              // Console.WriteLine(b + " " + c + " "+a);
           
           // else if (c < a  && a < b)
              // Console.WriteLine(c + " " + a + " "+b);
          
           // else if (c < a  && a > c)
              // Console.WriteLine(c + " " + b + " "+a);

           // Console.ReadKey();

            //-----------------------------------------------------------------------------------------------------------------------------

            //Atividade 8

           // int ano;

            // Console.WriteLine("escreve um ano: ");
            // ano = int.Parse(Console.ReadLine());

            // if (ano % 4 == 0)
            // {
            //     Console.WriteLine("O ano é bissexto");
            // }
            // else
            // {
            //     Console.WriteLine("O ano não é bissexto");
            // }

            //--------------------------------------------------------------------------------------------------------------------------------

             // Atividade 9

             //double a, b, r;
             //char apli;

           // Console.WriteLine("escreve um valor para a: ");
           //  a = double.Parse(Console.ReadLine());
           // Console.WriteLine("escreve um valor para b: ");
          //   b = double.Parse(Console.ReadLine());
           // Console.WriteLine("escreve uma operação: ");
           //  apli = char.Parse(Console.ReadLine());

           // if (apli == '+')
          //  {
          //      Console.WriteLine(a + b);
          //  }
           //  else if (apli == '-')
           //  {
           //      Console.WriteLine(a - b);
           //  }
           //  else if (apli == '*')
           //  {
           //      Console.WriteLine(a * b);
           //  }
         //    else if (apli == '/')
         //    {
           //     Console.WriteLine(a / b);
         //    }
          
            //-----------------------------------------------------------------------------------------------------------------------------------------

            // Atividade 10

            // Na linguagem C#, é possível gerar números aleatórios usando a classe Random. Esta classe permite gerar números inteiros e reais aleatórios usando diferentes métodos.
            // Para gerar números inteiros aleatórios em C#, basta criar uma instância da classe Random e chamar o método Next() da seguinte forma:

            // Aleatório random = new Random();
            // int randomInt = random.Next();

            // Para gerar números aleatórios reais em C#, é possível usar o método NextDouble(), que retorna um número aleatório entre 0 e 1, Se quiser gerar um número aleatório dentro de um intervalo específico, basta multiplicar o resultado pelo tamanho do intervalo e somar o valor mínimo

            // Aleatório random = new Random();
            // double randomDouble = Random.NextDouble();

            // Em ambos os casos, é importante criar uma única instância da classe Random e reutilizá-la para gerar números aleatórios diferentes. Isso porque, se você criar várias instâncias em sucessão rápida, elas podem gerar números semelhantes, tornando a distribuição menos aleatória.




        }
    }
}

        
    

