using UnityEngine;

public class ToiletScript : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public GameObject toiletWater;

    public AudioSource source;
    public AudioClip flushWater;

    int flushing = 0;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
        {
            if (hit.transform.name == "Toilet")
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    flushing = 200;
                    toiletWater.SetActive(true);
                    transform.GetComponent<AudioSource>().PlayOneShot(flushWater);
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (flushing > 0)
        {
            flushing--;
        } else
        {
            toiletWater.SetActive(false);
        }
    }
}
