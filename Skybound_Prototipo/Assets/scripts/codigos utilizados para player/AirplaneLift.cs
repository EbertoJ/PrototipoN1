using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AirplaneLift : MonoBehaviour
{
    public float liftFactor = 2.0f;
    public float minLiftSpeed = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Aplica sustentación solo si el avión va suficientemente rápido
        float forwardSpeed = Vector3.Dot(rb.linearVelocity, transform.forward);

        if (forwardSpeed > minLiftSpeed)
        {
            float lift = forwardSpeed * liftFactor;
            rb.AddForce(transform.up * lift);
        }
    }
}
