using UnityEngine;

public class Door1Script : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public AudioSource source;
    public AudioClip clip;
    public AudioClip giggle;
    public AudioSource giggleSource;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 1))
        {
            if (KeyScript.hasKey1)
            {
                if (hit.transform.name == "Door1")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        source.PlayOneShot(clip);
                        giggleSource.PlayOneShot(giggle);
                        hit.transform.GetComponent<Animator>().Play("Door1Animation", 0);
                        KeyScript.hasKey1 = false;
                    }
                }
            }
        }
    }
}
