using UnityEngine;
using UnityEngine.SceneManagement;

public class GenerarMascara : MonoBehaviour
{
    public GameObject[] spritesPrefabs; // Prefabs en el Inspector
    public SpritesGenerativos_Mascara generadorSprites; // Referencia al script GenerarSpritesEnMascara

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "ResultadoFinal")
        {
            // Llamar a los métodos para obtener la figura y el color seleccionados
            Sprite figuraSeleccionada = ObtenerFiguraSeleccionada();
            Color colorSeleccionado = ObtenerColorSeleccionado();
            int cantidadSprites = DecisionesUsuario.cantidad; // Obtener la cantidad
            // Llamar al generador de sprites para crear los sprites dentro de la máscara
            generadorSprites.GenerarSprites(figuraSeleccionada, colorSeleccionado, cantidadSprites);
        }
    }

    // Método para obtener la figura seleccionada
    private Sprite ObtenerFiguraSeleccionada()
    {
        switch (DecisionesUsuario.figura)
        {
            case "triangulo": return spritesPrefabs[0].GetComponent<SpriteRenderer>().sprite; // Asume que el sprite está en el prefab
            case "circulo": return spritesPrefabs[1].GetComponent<SpriteRenderer>().sprite;
            case "cuadrado": return spritesPrefabs[2].GetComponent<SpriteRenderer>().sprite;
            default: return null;  // Valor por defecto si no se selecciona ninguna figura
        }
    }

    // Método para obtener el color seleccionado
    private Color ObtenerColorSeleccionado()
    {
        switch (DecisionesUsuario.color)
        {
            case "azul": return Color.blue;
            case "rojo": return Color.red;
            case "verde": return Color.green;
            default: return Color.white;  // Valor por defecto si no se selecciona ningún color
        }
    }
}
