using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRotation : MonoBehaviour
{
    // Variables públicas para seleccionar la rotación y la velocidad desde el inspector
    public bool rotateOnX = false;
    public bool rotateOnY = false;
    public float rotationSpeedX = 10f;
    public float rotationSpeedY = 10f;

    void Update()
    {
        // Si la rotación en X está activada, rota alrededor del eje X
        if (rotateOnX)
        {
            transform.Rotate(Vector3.right * rotationSpeedX * Time.deltaTime);
        }

        // Si la rotación en Y está activada, rota alrededor del eje Y
        if (rotateOnY)
        {
            transform.Rotate(Vector3.up * rotationSpeedY * Time.deltaTime);
        }
    }
}