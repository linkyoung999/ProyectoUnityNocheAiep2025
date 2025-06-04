using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneChanger : MonoBehaviour
{
    [Tooltip("Nombre de la escena a cargar")]
    public string sceneName;

    // Método público para cambiar de escena (se usa con el evento OnClick del botón)
    public void ChangeScene()
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

    // Método público para cambiar de escena con parámetro
    public void ChangeScene(string newSceneName)
    {
        sceneName = newSceneName;
        ChangeScene();
    }
}