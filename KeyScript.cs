using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public Camera playerCam;
    public static bool hasKey1 = false;
    public static bool hasKey2 = false;
    public GameObject interact;
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
        {
            if (hit.transform.name == "Key")
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    source.PlayOneShot(clip);
                    hasKey1 = true;
                    Destroy(hit.transform.parent.gameObject);
                }
            }

            if (hit.transform.name == "Key2")
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    source.PlayOneShot(clip);
                    hasKey2 = true;
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
