using PenduloSimples.Model;
using System;

namespace PenduloSimples.Services
{
    internal class ServicePendulo
    {
        //Constante universal da gravidade na Terra
        const double aceleracaoGravidade = 9.81;

        static double CalcularPeriodo(Pendulo p)
        {
            double periodo = 2 * Math.PI * Math.Sqrt(p.ComprimentoFio / aceleracaoGravidade);
            return periodo;
        }

        static double CalcularFrequencia(Pendulo p)
        {
            return 1/CalcularPeriodo(p);
        }

        static double CalcularVelocidadeAngular(Pendulo p)
        {
            return (2*Math.PI)/CalcularPeriodo(p);
        }


    }
}
