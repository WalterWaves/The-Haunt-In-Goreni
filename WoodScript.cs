using UnityEngine;

public class WoodScript : MonoBehaviour
{
    public bool hasWood = false;
    public Camera playerCam;
    public GameObject interact;
    public GameObject wood;
    public GameObject wood2;
    public GameObject wood3;
    public GameObject wood4;
    public GameObject wood5;
    public GameObject door;
    public GameObject throwItem;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
        {
            if (hit.transform.name == "Wood" && !hasWood)
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    hasWood = true;
                    wood.transform.parent = playerCam.transform;
                    wood.GetComponent<Rigidbody>().useGravity = false;
                    wood.GetComponent<Rigidbody>().isKinematic = true;
                    wood2.GetComponent<Rigidbody>().useGravity = true;
                    wood2.GetComponent<Rigidbody>().isKinematic = false;
                    wood3.GetComponent<Rigidbody>().useGravity = true;
                    wood3.GetComponent<Rigidbody>().isKinematic = false;
                    wood4.GetComponent<Rigidbody>().useGravity = true;
                    wood4.GetComponent<Rigidbody>().isKinematic = false;
                    wood5.GetComponent<Rigidbody>().useGravity = true;
                    wood5.GetComponent<Rigidbody>().isKinematic = false;
                    door.GetComponent<Rigidbody>().useGravity = true;
                    door.GetComponent<Rigidbody>().isKinematic = false;
                    hit.transform.GetComponent<MeshCollider>().enabled = false;
                }
            }
        }

        if (hasWood)
        {
            throwItem.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                wood.GetComponent<MeshCollider>().enabled = true;
                wood.transform.parent = null;
                wood.GetComponent<Rigidbody>().useGravity = true;
                wood.GetComponent<Rigidbody>().isKinematic = false;
                wood.GetComponent<Rigidbody>().AddForce(playerCam.transform.forward * 1000);
                hasWood = false;
            }
        }
    }
}
