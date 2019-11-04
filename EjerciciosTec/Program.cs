using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //SumatoriaConDatosDeEntradaDelUsuarioValidandoHastaQueIngreseUnValorCorrecto();

            //SumatoriaConDatosDeEntradaDelUsuarioValidandoHastaQueIngreseUnValorCorrectoConDoWhile();

            SumatoriaConClases();
        }

        static void SumaConCicloForIniciadoEn1()
        {
            int sumatoria = 0;

            for (int i = 1; i <= 5; i++)
            {
                sumatoria = sumatoria + i;
            }

            Console.WriteLine("Sumatoria: " + sumatoria);

            Console.ReadLine();
        }

        static void SumaConCicloForIniciadoEn0()
        {
            int sumatoria = 0;

            for (int i = 0; i < 5; i++)
            {
                sumatoria = sumatoria + (i + 1);
            }

            Console.WriteLine("Sumatoria: " + sumatoria);

            Console.ReadLine();
        }

        static void SumaConCicloWhile()
        {
            int sumatoria = 0;

            int i = 0;
            while (i < 5)
            {
                //sumatoria = sumatoria + (i + 1);
                sumatoria += (i + 1);
                //i = i + 1; --> i++;
                i++;
            }

            Console.WriteLine("Sumatoria: " + sumatoria);

            Console.ReadLine();
        }
        static void SumaConCicloDoWhile()
        {
            int sumatoria = 0;

            //int i = 0;
            //do
            //{
            //    sumatoria += (i + 1);
            //    i++;
            //} while (i < 5);

            int i = 1;
            do
            {
                sumatoria += i;
                i++;
            } while (i < 5);

            Console.WriteLine("Sumatoria: " + sumatoria);

            Console.ReadLine();
        }

        static void SumaConParametros(int valorFinal)
        {
            int sumatoria = 0;

            for (int i = 1; i <= valorFinal; i++)
            {
                sumatoria = sumatoria + i;
            }

            Console.WriteLine("Sumatoria del 1 al " + valorFinal + ": " + sumatoria);

            Console.ReadLine();
        }

        static int Sumatoria(int valorFinal)
        {
            int sumatoria = 0;

            for (int i = 1; i <= valorFinal; i++)
            {
                sumatoria = sumatoria + i;
            }

            return sumatoria;
        }

        static void SumatoriaConParametroDeSalida(int valorFinal, out int resultado)
        {
            int sumatoria = 0;

            for (int i = 1; i <= valorFinal; i++)
            {
                sumatoria = sumatoria + i;
            }

            resultado = sumatoria;
        }

        static void SumatoriaConDatosDeEntradaDelUsuario()
        {
            Console.WriteLine("Usuario ingrese el valor para aplicar la sumatoria:");
            int valorFinalDelUsuario = int.Parse(Console.ReadLine());

            int resultadoSumatoria = Sumatoria(valorFinalDelUsuario);

            //int resultadoSumatoria;
            //SumatoriaConParametroDeSlida(valorFinalDelUsuario, out resultadoSumatoria);

            Console.WriteLine("Sumatoria del 1 al " + valorFinalDelUsuario + ": " + resultadoSumatoria);
            Console.ReadLine();
        }

        static void SumatoriaConDatosDeEntradaDelUsuarioValidandoElDatoIngresado()
        {
            Console.WriteLine("Usuario ingrese el valor para aplicar la sumatoria:");

            string valorEscritorPorElUsuario = Console.ReadLine();

            int valorFinalDelUsuario;
            bool elValorEsEntero = int.TryParse(valorEscritorPorElUsuario, out valorFinalDelUsuario);

            if (elValorEsEntero)
            {
                int resultadoSumatoria = Sumatoria(valorFinalDelUsuario);
                Console.WriteLine("Sumatoria del 1 al " + valorFinalDelUsuario + ": " + resultadoSumatoria);
            }
            else
            {
                Console.WriteLine("Error, el usuario ingreso un valor no numerico");
            }
            
            Console.ReadLine();
        }

        static void SumatoriaConDatosDeEntradaDelUsuarioValidandoHastaQueIngreseUnValorCorrecto()
        {
            Console.WriteLine("Usuario ingrese el valor para aplicar la sumatoria:");

            string valorEscritorPorElUsuario = Console.ReadLine();

            int valorFinalDelUsuario;
            bool elValorEsEntero = int.TryParse(valorEscritorPorElUsuario, out valorFinalDelUsuario);

            while(elValorEsEntero == false)
            {
                Console.WriteLine("Valor incorrecto, ingrese un valor correcto:");
                valorEscritorPorElUsuario = Console.ReadLine();
                elValorEsEntero = int.TryParse(valorEscritorPorElUsuario, out valorFinalDelUsuario);
            }

            int resultadoSumatoria = Sumatoria(valorFinalDelUsuario);
            Console.WriteLine("Sumatoria del 1 al " + valorFinalDelUsuario + ": " + resultadoSumatoria);

            Console.ReadLine();
        }

        static void SumatoriaConDatosDeEntradaDelUsuarioValidandoHastaQueIngreseUnValorCorrectoConDoWhile()
        {
            //inicializar variables
            int valorFinalDelUsuario;
            bool elValorEsEntero;

            do
            {
                Console.WriteLine("Usuario ingrese el valor para aplicar la sumatoria:");

                string valorEscritorPorElUsuario = Console.ReadLine();

                elValorEsEntero = int.TryParse(valorEscritorPorElUsuario, out valorFinalDelUsuario);

                if (elValorEsEntero == false)
                    Console.WriteLine("Error, valor incorrecto.");

            } while (elValorEsEntero == false);

            int resultadoSumatoria = Sumatoria(valorFinalDelUsuario);
            Console.WriteLine("Sumatoria del 1 al " + valorFinalDelUsuario + ": " + resultadoSumatoria);

            Console.ReadLine();
        }

        static void SumatoriaConClases()
        {
            var objetoSumatoria = new ProblemaSumatoria();
            objetoSumatoria.AsignarValorASumar(5);
            Console.WriteLine(objetoSumatoria.ValorInicial);
            Console.WriteLine(objetoSumatoria.ValorFinal);
            Console.WriteLine(objetoSumatoria.ValorSumatoria);
            Console.ReadLine();
        }
    }
}
