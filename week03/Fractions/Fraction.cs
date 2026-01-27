using System;

public class Fraction
{
    private int _top;   // atributo privado para el numerador
    private int _bottom;   // atributo privado para el denominador

    public Fraction()  // Esta es la puerta que se usa cuando escribo: new Fraction(); “Si alguien crea una fracción sin decirme nada, entonces será 1/1”
    {
        _top = 1;   // asigna 1 al atributo _top
        _bottom = 1;   // asigna 1 al atributo _bottom
    }

    public Fraction(int top)  // Cuando se usa este: new Fraction(5); Dice “Si alguien me da un número, ese número será el top, y el bottom será 1” Resultado 5/1
    {
        _top = top;   // top NO es el atributo, top = parámetro, vive solo dentro del constructor, viene de afuera.
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;   // el valor que se le da a top debe ser en No. entero y se asigna al atributo _top
        _bottom = bottom;   // el valor que se le da a bottom debe ser en No. entero y se asigna al atributo _bottom
    }

    public int GetTop()   // Método para obtener en No. enteros el valor del atributo _top
    {
        return _top;   // Ayuda a saber el valor del atributo _top
    }

    public void SetTop(int value)  // Método para asignar un valor en No. entero (cambiar el valor privado de _top)  al atributo _top
    {
        _top = value;   // Cambia el valor que viene de afuera (value) al atributo _top
    }

    public int GetBottom()   // Método para obtener en No. enteros el valor del atributo _bottom
    {
        return _bottom;   // Ayuda a saber el valor del atributo _bottom
    }

    public void SetBottom(int value)   // Método para asignar un valor en No. entero (cambiar el valor privado de _bottom) al atributo _bottom
    {
        _bottom = value;   // Cambia el valor que viene de afuera (value) al atributo _bottom
    }

    public string GetFractionString()   // Método para obtener (ver) la fracción en formato string (palabras escritas)
    {
        return _top + "/" + _bottom;   // Devuelve la fracción como una cadena de texto. El "/" es para separar el numerador y el denominador no es una división.
    }

    public double GetDecimalValue()   // Método para obtener el valor decimal de la fracción
    {
        return (double)_top / _bottom;   // Convierte el numerador (_top) a double para evitar la división entera y luego divide por el denominador (_bottom)
    }
}




