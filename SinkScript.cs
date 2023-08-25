using UnityEngine;

public class SinkScript : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public GameObject water;

    public AudioSource source;
    public AudioClip tap;

    bool on = false;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
        {
            if (hit.transform.name == "Sink")
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    on = !on;
                    water.SetActive(on);
                    transform.GetComponent<AudioSource>().PlayOneShot(tap);
                    if (on)
                    {
                        source.enabled = true;
                    } else
                    {
                        source.enabled = false;
                    }
                }
            }
        }
    }
}
