using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerWithDelay : MonoBehaviour
{
    [Tooltip("Nombre de la escena a cargar")]
    public string sceneName;

    [Tooltip("Tiempo de espera antes de cambiar de escena (en segundos)")]
    public float delayTime = 1f;

    // Método opcional de inicialización
    private void Start()
    {
        // Puedes usar esto para depuración o verificación inicial
        Debug.Log("SceneChangerWithDelay inicializado. Escena objetivo: " + sceneName);

        // Opcional: Validar que la escena existe en Build Settings
        /*
        if (!string.IsNullOrEmpty(sceneName))
        {
            if (SceneUtility.GetBuildIndexByScenePath(sceneName) < 0)
            {
                Debug.LogWarning("La escena '" + sceneName + "' no existe en Build Settings");
            }
        }
        */
    }

    // Método público para iniciar el cambio de escena con delay
    public void ChangeSceneWithDelay()
    {
        Invoke("LoadScene", delayTime);
    }

    // Método público para cambiar de escena con parámetros
    public void ChangeSceneWithDelay(string newSceneName, float newDelayTime)
    {
        sceneName = newSceneName;
        delayTime = newDelayTime;
        Invoke("LoadScene", delayTime);
    }

    private void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is not specified!");
        }
    }
}