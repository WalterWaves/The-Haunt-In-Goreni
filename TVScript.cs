using UnityEngine;

public class TVScript : MonoBehaviour
{
    public GameObject player;
    public GameObject lightObj;
    void Update()
    {
        if (player.transform.position.x >= 8 && player.transform.position.z <= 2)
        {
            if (!lightObj.activeInHierarchy)
            {
                lightObj.SetActive(true);
                transform.GetComponent<AudioSource>().enabled = true;
            }
        }
    }
}
