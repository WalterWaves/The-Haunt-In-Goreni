using UnityEngine;
using UnityEngine.SceneManagement;

public class UserSettings : MonoBehaviour
{
    public static float sensitivity;
    public static float volume;

    void Start()
    {
        sensitivity = 2;
        volume = 50;
    }
    void Update()
    {
        AudioListener.volume = volume / 50;
        if (SceneManager.GetActiveScene().name == "Main")
        {
            GameObject.Find("FirstPersonController").transform.GetComponent<FirstPersonController>().mouseSensitivity = sensitivity;       
        }
    }
}
