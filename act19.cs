using System;
using System.Collections.Generic;

public class MaquinaExpendora
{
    private double saldo;
    private double preuTiquet;

    public MaquinaExpendora(double preuTiquet)
    {
        this.saldo = 0;
        this.preuTiquet = preuTiquet;
    }

    public double GetSaldo()
    {
        return saldo;
    }

    public void InserirMoneda(double import)
    {
        saldo += import;
    }

    public string TreureTiquet()
    {
        if (saldo >= preuTiquet)
        {
            double canvi = saldo - preuTiquet;
            Dictionary<double, int> monedes = new Dictionary<double, int>()
            {
                { 2.0, 0 },
                { 1.0, 0 },
                { 0.5, 0 },
                { 0.2, 0 },
                { 0.1, 0 }
            };

            foreach (var moneda in monedes.Keys)
            {
                while (canvi >= moneda)
                {
                    canvi -= moneda;
                    monedes[moneda]++;
                }
            }

            saldo = 0;
            string result = "Canvi:";
            foreach (var moneda in monedes)
            {
                if (moneda.Value > 0)
                    result += $" {moneda.Value} moneda(s) de {moneda.Key}€,";
            }
            return result.TrimEnd(',');
        }
        else
        {
            return "Introdueixi l'import exacte.";
        }
    }
}

class Program
{
    static void Main()
    {
        MaquinaExpendora maquina = new MaquinaExpendora(1.20);

        maquina.InserirMoneda(5.0);
        Console.WriteLine(maquina.TreureTiquet()); // Debería imprimir: Canvi: 1 moneda(s) de 2€, 1 moneda(s) de 1€, 1 moneda(s) de 0,5€, 1 moneda(s) de 0,2€, 1 moneda(s) de 0,1€

        maquina.InserirMoneda(1.0);
        Console.WriteLine(maquina.TreureTiquet()); // Debería imprimir: Introdueixi l'import exacte.

        maquina.InserirMoneda(2.0);
        maquina.InserirMoneda(2.0);
        maquina.InserirMoneda(0.5);
        maquina.InserirMoneda(0.2);
        maquina.InserirMoneda(0.1);
        Console.WriteLine(maquina.TreureTiquet()); // Debería imprimir: Canvi:
    }
}
