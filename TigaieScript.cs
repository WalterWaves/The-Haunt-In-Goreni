using UnityEngine;
using static Unity.VisualScripting.Member;

public class TigaieScript : MonoBehaviour
{
    public bool hasTiagie = false;
    public Camera playerCam;
    public GameObject interact;
    public GameObject tigaie;
    public GameObject throwItem;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
        {
            if (hit.transform.name == "Tigaie" && !hasTiagie)
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    hasTiagie = true;
                    tigaie.transform.parent = playerCam.transform;
                    tigaie.GetComponent<Rigidbody>().useGravity = false;
                    tigaie.GetComponent<Rigidbody>().isKinematic = true;
                    hit.transform.GetComponent<AudioSource>().enabled = true;
                    hit.transform.GetComponent<MeshCollider>().enabled = false;
                }
            }
        }

        if (hasTiagie)
        {
            throwItem.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                tigaie.GetComponent<MeshCollider>().enabled = true;
                tigaie.transform.parent = null;
                tigaie.GetComponent<Rigidbody>().useGravity = true;
                tigaie.GetComponent<Rigidbody>().isKinematic = false;
                tigaie.GetComponent<Rigidbody>().AddForce(playerCam.transform.forward * 1000);
                hasTiagie = false;
            }
        }
    }
}
