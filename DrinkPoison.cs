using UnityEngine;
using UnityEngine.SceneManagement;

public class DrinkPoison : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public GameObject mainBlack;
    public AudioSource source;
    public AudioClip clip;

    bool started = false;
    int ticks = 0;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
        {
            if (hit.transform.name == "Bottle")
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    source.PlayOneShot(clip);
                    Destroy(hit.transform.gameObject);
                    mainBlack.SetActive(true);
                    mainBlack.GetComponent<Animator>().Play("MainBlack", 0);
                    started = true;
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (started)
        {
            ticks++;
            if (ticks == 250)
            {
                SceneManager.LoadScene("Cutscene2");
            }
        }
    }
}
