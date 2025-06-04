using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    // Variable pública para ajustar la velocidad de rotación desde el Inspector
    public float rotationSpeed = 1.0f;

    void Update()
    {
        // Rotar el Skybox en función de la velocidad de rotación y el tiempo transcurrido
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
