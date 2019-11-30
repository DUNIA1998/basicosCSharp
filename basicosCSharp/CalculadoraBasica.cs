using System;

public class CalculadoraBasica
{
	public CalculadoraBasica()
	{

    }

    private double ultimoResultado;
    public double Sumar(double primerValor, double segundoValor)
        {
            ultimoResultado = primerValor + segundoValor;
            return ultimoResultado;

        }

    public double Dividir(double primerValor, double segundoValor)
        {
            ultimoResultado = primerValor / segundoValor;
            return ultimoResultado;

        }
}
