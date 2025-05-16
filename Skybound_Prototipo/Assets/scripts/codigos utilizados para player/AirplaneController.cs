using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SimpleAirplaneController : MonoBehaviour
{
    public float acceleration = 20f;
    public float maxSpeed = 100f;
    public float liftFactor = 2f;
    public float minLiftSpeed = 10f;
    public float turnSpeed = 50f;
    public float drag = 0.98f;
    public float reverseSpeed = 10f;
    public float gravityForce = 9.8f;

    private float currentSpeed = 0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // Controlamos gravedad manualmente
        rb.constraints = RigidbodyConstraints.FreezeRotation; // Sin inclinación realista por ahora
    }

    void FixedUpdate()
    {
        // Aceleración con W
        if (Input.GetKey(KeyCode.W))
        {
            currentSpeed += acceleration * Time.fixedDeltaTime;
            currentSpeed = Mathf.Clamp(currentSpeed, 0f, maxSpeed);
        }
        else
        {
            currentSpeed *= drag;
        }

        // Movimiento hacia adelante
        Vector3 forwardMovement = transform.forward * currentSpeed;
        rb.linearVelocity = new Vector3(forwardMovement.x, rb.linearVelocity.y, forwardMovement.z);

        // Movimiento lateral con A y D
        float horizontalInput = Input.GetAxis("Horizontal"); // -1 (A) a 1 (D)
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.fixedDeltaTime);

        // Sustentación simulada: solo si va rápido
        float forwardSpeed = Vector3.Dot(rb.linearVelocity, transform.forward);
        if (forwardSpeed > minLiftSpeed)
        {
            float lift = forwardSpeed * liftFactor * Time.fixedDeltaTime;
            rb.AddForce(Vector3.up * lift, ForceMode.Acceleration);
        }

        // Simulación de gravedad manual si no hay sustentación
        if (forwardSpeed <= minLiftSpeed)
        {
            rb.AddForce(Vector3.down * gravityForce, ForceMode.Acceleration);
        }

        // Frenar o retroceder con S (solo si está en el suelo)
        if (Input.GetKey(KeyCode.S) && IsGrounded())
        {
            currentSpeed = 0f;
            rb.linearVelocity = -transform.forward * reverseSpeed;
        }
        
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }



    public float GetCurrentSpeed()
    {
        return currentSpeed;
    }

}
