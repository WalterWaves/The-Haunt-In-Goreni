using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene2 : MonoBehaviour
{

    int ticks = 0;

    void FixedUpdate()
    {
        ticks++;
        if (ticks == 1250)
        {

            Loading.destination = "Basement";
            SceneManager.LoadScene("LoadingScreen");
        }
    }
}
