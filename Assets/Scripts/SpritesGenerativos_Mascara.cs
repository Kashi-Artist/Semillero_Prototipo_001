using UnityEngine;

public class SpritesGenerativos_Mascara : MonoBehaviour
{
    public GameObject[] spritesPrefabs; // Asigna tus prefabs en el Inspector
    public SpriteMask spriteMask; // Asigna tu SpriteMask en el Inspector
    public Transform contenedorMascara;

    // Método para generar los sprites dentro de la máscara
    public void GenerarSprites(Sprite figura, Color color, int cantidad)
    {
        if (figura == null)
        {
            Debug.LogWarning("No se ha seleccionado ninguna figura.");
            return; // Salir si no hay figura
        }

        // Obtener las dimensiones de la SpriteMask
        RectTransform maskRect = spriteMask.GetComponent<RectTransform>();
        float maskWidth = maskRect.rect.width;
        float maskHeight = maskRect.rect.height;
        // Obtener el componente SpriteRenderer del contenedor
        SpriteRenderer contenedorRenderer = contenedorMascara.GetComponent<SpriteRenderer>();
        int contenedorSortingOrder = contenedorRenderer != null ? contenedorRenderer.sortingOrder-1 : 0; // Valor por defecto si no hay SpriteRenderer

        for (int i = 0; i < cantidad; i++)
        {
            // Generar e instanciar el sprite en la posición transformada
            float xPos = Random.Range(-maskWidth / 2, maskWidth / 2);
            float yPos = Random.Range(-maskHeight / 2, maskHeight / 2);
            Vector3 posicionLocal = contenedorMascara.TransformPoint(new Vector3(xPos, yPos,0));

            GameObject sprite = Instantiate(spritesPrefabs[0], posicionLocal, Quaternion.identity, contenedorMascara); // Instanciar y asignar como hijo directamente

            // Ajustar la escala del sprite en relación al tamaño de la máscara
            //float escala = Mathf.Min(maskWidth, maskHeight) / 100f; // Ajustar 100f según sea necesario
            //sprite.transform.localScale = new Vector3(escala, escala, 1);

            // Obtener el componente SpriteRenderer y asignar el color
            SpriteRenderer spriteRenderer = sprite.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.sprite = figura; // Asigna la figura seleccionada
                spriteRenderer.color = color; // Asignar el color seleccionado
                spriteRenderer.maskInteraction = SpriteMaskInteraction.VisibleInsideMask; // Interacción con la máscara
            // Ajustar el orden en la capa basado en el del contenedor
                spriteRenderer.sortingOrder = contenedorSortingOrder-i; // Los que se crean estan detras del anterior
            }
        }
    }
}
