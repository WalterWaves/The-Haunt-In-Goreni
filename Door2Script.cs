using UnityEngine;

public class Door2Script : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 1))
        {
            if (KeyScript.hasKey2)
            {
                if (hit.transform.name == "Door3")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        hit.transform.GetComponent<Animator>().Play("Door2Animation", 0);
                        source.PlayOneShot(clip);
                        KeyScript.hasKey2 = false;
                    }
                }
            }
        }
    }
}
