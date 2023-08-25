using UnityEngine;

public class AragazScript : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public GameObject subtitles;
    public AudioSource source;
    public AudioClip clip;
    public static bool aragazBroken = false;

    int cooldown = 0;

    void Update()
    {
        if (cooldown == 0 && aragazBroken == false)
        {
            RaycastHit hit;
            if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
            {
                if (hit.transform.name == "AragazFrame" || hit.transform.name == "AragazGlass")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        subtitles.SetActive(true);
                        source.PlayOneShot(clip);
                        cooldown = 200;
                    }
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (cooldown > 0)
        {
            cooldown--;
            if (cooldown == 1)
            {
                subtitles.SetActive(false);
            }
        }
    }
}
