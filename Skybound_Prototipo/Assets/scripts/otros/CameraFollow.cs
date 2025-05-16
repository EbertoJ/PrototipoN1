using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El jugador o nave
    public Vector3 offset = new Vector3(0, 5, -10); // Ajusta la posición de la cámara

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(target); // La cámara siempre mira al jugador
        }
    }
}
