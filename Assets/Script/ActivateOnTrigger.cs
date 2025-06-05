using UnityEngine;

public class ActivateOnTrigger : MonoBehaviour
{
    // Referencia al GameObject que queremos activar
    public GameObject objectToActivate;

    // Tag del jugador para identificarlo
    public string playerTag = "Player";

    // Método que se llama cuando otro objeto entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entra en el trigger tiene el tag del jugador
        if (other.CompareTag(playerTag))
        {
            // Activa el GameObject
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
            }
        }
    }
}
