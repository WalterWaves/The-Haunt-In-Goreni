using UnityEngine;

public class Firecracker_Pickup : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public GameObject inventory;
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
        {
            if (hit.transform.name == "Firecracker")
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    source.PlayOneShot(clip);
                    inventory.GetComponent<InventoryScript>().item1 = "firecracker";
                    inventory.GetComponent<InventoryScript>().amount1++;
                    Destroy(hit.transform.parent.gameObject);
                }
            }
        }
    }
}
