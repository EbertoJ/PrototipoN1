using UnityEngine;
using UnityEngine.SceneManagement;

public class AirplaneCrashHandler : MonoBehaviour
{
    public GameObject explosionEffect; // Arrástralo en el Inspector
    public float crashThreshold = 20f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstaculo"))
        {
            float impactForce = collision.relativeVelocity.magnitude;

            if (impactForce > crashThreshold)
            {
                Debug.Log("¡Colisión fuerte con el obstaculo!");

                if (explosionEffect != null)
                {
                    Instantiate(explosionEffect, transform.position, Quaternion.identity);
                }

                Destroy(gameObject); // Destruye el avión

                // Opcional: reinicia la escena tras 2 segundos
                Invoke("ReloadScene", 2f);
            }
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
