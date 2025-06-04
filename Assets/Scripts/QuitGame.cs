using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Este método será llamado cuando el botón sea presionado
    public void Quit()
    {
        // Si estamos en el editor de Unity, paramos la simulación del juego
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Si estamos en una build (Windows, Mac, Linux), cerramos la aplicación
            Application.Quit();
#endif
    }
}