using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Importante para hacer cambios de Escena

public class ChangeSceneTimer : MonoBehaviour
{
    [Tooltip("Tiempo en segundos antes de cambiar la escena.")]
    public float delay = 5f;

    [Tooltip("Nombre de la escena a cargar. Déjalo en blanco si quieres usar el índice.")]
    public string sceneName = "";

    [Tooltip("Índice de la escena a cargar en el Build Settings. Ignorado si el nombre de la escena no está vacío.")]
    public int sceneIndex = -1;

    void Start()
    {
        // Comenzar la corrutina para cambiar la escena después del retraso especificado
        StartCoroutine(ChangeSceneAfterDelay());
    }

    private IEnumerator ChangeSceneAfterDelay()
    {
        // Esperar el tiempo especificado
        yield return new WaitForSeconds(delay);

        // Cargar la escena por nombre o por índice
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else if (sceneIndex >= 0)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogError("Ni el nombre de la escena ni el índice de la escena están correctamente configurados.");
        }
    }
}