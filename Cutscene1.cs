using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene1 : MonoBehaviour
{
    int ticks = 0;
    public GameObject subtitles;
    public GameObject subtitles2;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Main");
        }
    }

    void FixedUpdate()
    {
        ticks++;
        if (ticks == 250)
        {
            subtitles.SetActive(true);
        }
        if (ticks == 400)
        {
            subtitles.SetActive(false);
        }
        if (ticks == 550)
        {
            subtitles2.SetActive(true);
        }
        if (ticks == 700)
        {
            subtitles2.SetActive(false);
        }

        if (ticks >= 1000)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
