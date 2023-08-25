using UnityEngine;

public class Firecracker_Throw : MonoBehaviour
{
    public GameObject inventory;
    public GameObject throwItem;
    public GameObject firecrackerObject;
    public Camera playerCam;
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        if (inventory.GetComponent<InventoryScript>().item1 == "firecracker" && inventory.GetComponent<InventoryScript>().amount1 > 0 && inventory.GetComponent<InventoryScript>().pie1)
        {
            throwItem.SetActive(true);
            if (Input.GetMouseButtonDown(1))
            {
                int x = Random.Range(0, 360);
                int y = Random.Range(0, 360);
                int z = Random.Range(0, 360);
                inventory.GetComponent<InventoryScript>().amount1--;
                GameObject firecracker = Instantiate(firecrackerObject);
                firecracker.transform.localPosition = transform.localPosition + new Vector3(0, 1, 0);
                firecracker.transform.localRotation = Quaternion.Euler(new Vector3(x, y, z));
                firecracker.GetComponent<Rigidbody>().useGravity = true;
                firecracker.GetComponent<Rigidbody>().AddForce(playerCam.transform.forward * 500);
                firecracker.GetComponent<Rigidbody>().AddForce(new Vector3(0, -250, 0));
                source.PlayOneShot(clip);
            }
        }
    }

    void FixedUpdate()
    {
        throwItem.SetActive(false);
    }
}
