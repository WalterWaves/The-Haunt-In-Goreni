using UnityEngine;
using UnityEngine.UI;

public class SensitivitySlider : MonoBehaviour
{
    void Update()
    {
        UserSettings.sensitivity = transform.GetComponent<Slider>().value;
        transform.Find("Value").transform.GetComponent<TMPro.TextMeshProUGUI>().text = Mathf.Round((transform.GetComponent<Slider>().value * 100.0f) * 0.01f).ToString();
    }
}
