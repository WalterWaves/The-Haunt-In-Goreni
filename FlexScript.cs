using UnityEngine;

public class FlexScript : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public GameObject flexInHand;
    public bool hasFlex = false;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
        {
            if (hit.transform.name == "Flex")
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    flexInHand.SetActive(true);
                    hasFlex = true;
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
