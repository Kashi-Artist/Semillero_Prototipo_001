using UnityEngine;

public class DecisionesUsuario : MonoBehaviour
{
    // Variables para almacenar las decisiones
    public static int cantidad;  // 1, 2 o 3 marcas
    public static string figura;  // "circulo", "triangulo", "cuadrado"
    public static string color;  // "azul", "rojo", "verde"

    // Método para guardar la cantidad de marcas
    public void GuardarCantidad(int seleccionCantidad)
    {
        cantidad = seleccionCantidad;
        Debug.Log("Cantidad seleccionada: " + cantidad);
    }

    // Método para guardar la figura seleccionada en el reto 2
    public void GuardarFigura(string seleccionFigura)
    {
        figura = seleccionFigura;
        Debug.Log("Figura seleccionada: " + figura);
    }

    // Método para guardar el color seleccionado en el reto 3
    public void GuardarColor(string seleccionColor)
    {
        color = seleccionColor;
        Debug.Log("Color seleccionado: " + color);
    }
}
