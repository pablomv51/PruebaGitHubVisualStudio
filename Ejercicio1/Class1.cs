using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Quebrado
    {
        public double Den { get; set; }

        public double Num { get; set; }

        public Quebrado(double num, double den)
        {
            
            if (den > 0) { 
            this.Den = den;
            this.Num = num;
            }
            else
            {
                this.Den = 1;
                this.Num = 0;
            }
        }

        public static double ValorReal(Quebrado q){

            return q.Num / q.Den;


        }

        public static Boolean EsEntero(Quebrado q)
        {
            double x = q.Num / q.Den;
            if (x % 1 == 0)
            {
                return true;
            }
            else return false;
        }

        public static double ComunDivisor (Quebrado q, Quebrado q2)
        {
            double mcd = 0;
            double a = Math.Max(q.Den, q2.Den);
            double b = Math.Min(q.Den, q2.Den);
            do{
                mcd = b;
                b = a % b;
                a = mcd;
            } while (b!=0);
            return mcd;

        }

        public static double ComunDivisorResultados(Double x, double y)
        {
            double mcd = 0;
            double a = Math.Max(x, y);
            double b = Math.Min(x, y);
            do
            {
                mcd = b;
                b = a % b;
                a = mcd;
            } while (b != 0);
            return mcd;

        }


        public static double ComunMultiplo(Quebrado q, Quebrado q2){


            double mcd = ComunDivisor(q, q2);
            double mcm = 0;
            double a = Math.Max(q.Den, q2.Den);
            double b = Math.Min(q.Den, q2.Den);
            mcm = (a / mcd) * b;
            return mcm;

        }

        public static string Suma(Quebrado q, Quebrado q2){

            double mcm = ComunMultiplo(q, q2);
            double numerador = ((mcm / q.Den) * q.Num) + ((mcm / q2.Den) * q2.Num);
            double den2;
            den2 = mcm / ComunDivisorResultados(mcm, numerador);
            numerador = numerador / ComunDivisorResultados(numerador, mcm);
            string resultado = numerador.ToString() + "/" + den2.ToString();
            return resultado;
        }

        public static string Resta(Quebrado q, Quebrado q2)
        {

            double mcm = ComunMultiplo(q, q2);
            double numerador = ((mcm / q.Den) * q.Num) - ((mcm / q2.Den) * q2.Num);
            double den2;
            den2 = mcm / ComunDivisorResultados(mcm, numerador);
            numerador = numerador / ComunDivisorResultados(numerador, mcm);
            string resultado = numerador.ToString() + "/" + den2.ToString();
            return resultado;
        }

        public static string Multiplicacion(Quebrado q, Quebrado q2)
        {

            double numerador = q.Num * q2.Num;
            double denominador = q.Den * q2.Den;
            double den2;
            den2 = denominador / ComunDivisorResultados(denominador, numerador);
            numerador = numerador / ComunDivisorResultados(numerador, denominador);
            string resultado = numerador.ToString() + "/" + den2.ToString();
            return resultado;
        }

        public static string Division(Quebrado q, Quebrado q2)
        {

            double numerador = q.Num * q2.Den;
            double denominador = q2.Num * q.Den;
            double den2;
            den2 = denominador / ComunDivisorResultados(denominador, numerador);
            numerador = numerador / ComunDivisorResultados(numerador, denominador);
            string resultado = numerador.ToString() + "/" + den2.ToString();
            return resultado;
        }

        public static Boolean MayorQue(Quebrado q, Quebrado q2)
        {

            if (ValorReal(q) > ValorReal(q2))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static Boolean MenorQue(Quebrado q, Quebrado q2)
        {

            if (ValorReal(q) < ValorReal(q2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static Boolean EsIgual(Quebrado q, Quebrado q2)
        {

            if (ValorReal(q) == ValorReal(q2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
