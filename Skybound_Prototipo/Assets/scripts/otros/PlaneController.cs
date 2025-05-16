using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 50f;
    public float liftForce = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Avanzar hacia adelante constantemente
        rb.AddForce(transform.forward * speed);

        // Controlar inclinación (pitch)
        float vertical = Input.GetAxis("Vertical"); // W/S
        rb.AddTorque(transform.right * vertical * rotationSpeed);

        // Controlar giro (yaw)
        float horizontal = Input.GetAxis("Horizontal"); // A/D
        rb.AddTorque(transform.up * horizontal * rotationSpeed);

        // Simulación de elevación (aumenta con velocidad)
        rb.AddForce(Vector3.up * liftForce);
    }
}

