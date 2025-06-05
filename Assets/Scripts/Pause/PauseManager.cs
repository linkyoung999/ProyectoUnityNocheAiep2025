using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public KeyCode pauseKey = KeyCode.Escape; // Tecla para pausar (cambiable en el Inspector)
    public GameObject pauseCanvas; // Referencia al Canvas de pausa

    private bool isPaused = false;

    void Update()
    {
        // Pausar/despausar con tecla
        if (Input.GetKeyDown(pauseKey))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        // Activar/desactivar canvas
        pauseCanvas.SetActive(isPaused);

        // Pausar/despausar el juego
        Time.timeScale = isPaused ? 0f : 1f;

        // Opcional: Bloquear/desbloquear cursor
        Cursor.lockState = isPaused ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = isPaused;
    }

    // Método para el botón "Resume"
    public void ResumeGame()
    {
        isPaused = false;
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}