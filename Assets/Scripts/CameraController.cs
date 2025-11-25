using UnityEngine;
using UnityEngine.InputSystem; // Seguimos usando el New Input System

public class CameraController : MonoBehaviour
{
    // Aumentamos la velocidad porque ahora son "grados por segundo"
    public float velocidadRotacion = 60f; 

    void Update()
    {
        if (Keyboard.current == null) return;

        // Girar a la Derecha (Tecla D)
        // Usamos Vector3.up porque queremos girar sobre el eje Y (vertical)
        if (Keyboard.current.dKey.isPressed)
        {
            transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
        }

        // Girar a la Izquierda (Tecla A)
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Rotate(Vector3.up * -velocidadRotacion * Time.deltaTime);
        }
    }
}