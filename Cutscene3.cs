using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene3 : MonoBehaviour
{
    int time = 0;

    void FixedUpdate()
    {
        time++;
        if (time >= 2700)
        {
            Loading.destination = "Hell";
            SceneManager.LoadScene("LoadingScreen");
        }
    }
}
