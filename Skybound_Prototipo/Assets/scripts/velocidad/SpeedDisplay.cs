using UnityEngine;
using TMPro;

public class SpeedDisplay : MonoBehaviour
{
    public SimpleAirplaneController airplaneController;
    public TMP_Text speedText;

    void Update()
    {
        if (airplaneController != null && speedText != null)
        {
            float speed = airplaneController.GetCurrentSpeed();
            speedText.text = "Velocidad: " + Mathf.RoundToInt(speed) + " km/h";
        }
    }
}
