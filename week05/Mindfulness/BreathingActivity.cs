using System;

public class BreathingActivity : Activity /* : hereda de la clase base Activity, lo que significa que BreathingActivity is a (:) Activity y puede usar sus métodos y atrubutos. */
{
    public BreathingActivity(string name, string description) : base(name, description) /* : base(name, description) es el constructor que llama a la clase base (Activity) para inicializar los atributos _name y _description ya que la clase base es private y primero se le avisa al contructor antes de hacer nada */
    {
    }

    public override void Run() /* La clase base esta definida como virtual y eso ayuda a que con override utilizada en las clases hijas pueda utilizar sus metodos y atributos. Run() permite la implementación especifica de BreathingActivity para realizar la actividad de respiración. */
    {
        StartMessage(); /* StartMessage() es un método definido en la clase base Activity que muestra un mensaje de bienvenida, la descripción de la actividad y solicita al usuario que ingrese la duración de la sesión. */

        int duration = GetDuration(); /* GetDuration() es un método definido en la clase base Activity que devuelve la duración de la sesión que el usuario ingresó en el método StartMessage(). */
        int elapsed = 0; /* elapsed lleva un seguimiento del tiempo transcurrido durante la actividad de respiración */

        while (elapsed < duration) /* este Loop se ejecuta mientras el enlapse sea menor que duration total para realizar la actividad de respiración. */
        {
            Console.Write("Breathe in... "); /* mensaje para empezar a respirar */
            ShowCountDown(4); /* aqui cuenta 4 segundos */
            Console.WriteLine(); /* salto de linea para mejorar la legibilidad */
            elapsed += 4; /* se suma 4 segundos al tiempo transcurrido */

            if (elapsed >= duration) break; /* si el tiempo transcurrido es mayor o igual a la duración total, se rompe el loop para evitar que se ejecute el siguiente paso de respirar out. */

            Console.Write("Now breathe out... "); /* mensaje para empezar a exhalar */
            ShowCountDown(4); /* aqui cuenta 4 segundos */
            Console.WriteLine(); /* salto de linea para mejorar la legibilidad */
            elapsed += 4; /* se suma 4 segundos al tiempo transcurrido */
        }

        EndMessage(); /* EndMessage() se llama al método de la clase base donde muestra un mensaje de felicitación al usuario por completar la actividad. */
    }
}
