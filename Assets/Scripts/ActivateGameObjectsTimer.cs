using UnityEngine;
using System.Collections; // Necesario para Coroutines

public class ActivateGameObjectsTimer : MonoBehaviour
{
    [Tooltip("Arrastra aquí los GameObjects que deseas activar.")]
    public GameObject[] objetosAActivar; // Array para arrastrar los objetos desde el Inspector

    [Tooltip("Tiempo en segundos antes de que los objetos sean activados.")]
    public float tiempoParaActivar = 1f; // Tiempo por defecto para la activación

    void Start()
    {
        // Inicia la coroutine para activar los objetos después de un tiempo
        StartCoroutine(ActivateRoutine());
    }

    public IEnumerator ActivateRoutine()
    {
        // Espera el tiempo especificado
        yield return new WaitForSeconds(tiempoParaActivar);

        // Itera a través de cada objeto en el array y lo activa
        foreach (GameObject obj in objetosAActivar)
        {
            if (obj != null) // Asegúrate de que el objeto no sea nulo
            {
                obj.SetActive(true);
                Debug.Log($"Objeto '{obj.name}' activado después de {tiempoParaActivar} segundos.");
            }
        }
    }
}
