using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjsWithTimer : MonoBehaviour
{
    [Tooltip("Arrastra aquí los GameObjects que deseas destruir.")]
    public GameObject[] objetosADestruir; // Array para arrastrar los objetos desde el Inspector

    [Tooltip("Tiempo en segundos antes de que los objetos sean destruidos.")]
    public float tiempoParaDestruir = 3f; // Tiempo por defecto para la destrucción

    void Start()
    {
        // Inicia la coroutine para destruir los objetos después de un tiempo
        StartCoroutine(DestruirObjetosDespuesDeTiempo());
    }

    IEnumerator DestruirObjetosDespuesDeTiempo()
    {
        // Espera el tiempo especificado
        yield return new WaitForSeconds(tiempoParaDestruir);

        // Itera a través de cada objeto en el array y lo destruye
        foreach (GameObject obj in objetosADestruir)
        {
            if (obj != null) // Asegúrate de que el objeto no sea nulo (por si ya fue destruido o no se asignó)
            {
                Destroy(obj);
                Debug.Log($"Objeto '{obj.name}' destruido después de {tiempoParaDestruir} segundos.");
            }
        }
    }
}