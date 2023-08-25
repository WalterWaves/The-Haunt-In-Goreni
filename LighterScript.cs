using UnityEngine;
using UnityEngine.SceneManagement;

public class LighterScript : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public GameObject inventory;
    public GameObject black;
    public AudioSource source;
    public AudioClip lighter;
    public AudioClip pickup;
    public AudioClip summon;
    public int litCandles = 0;
    public Animator animator;

    bool started = false;
    int time = 300;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
        {
            if (hit.transform.name == "Lighter")
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    source.PlayOneShot(pickup);
                    inventory.GetComponent<InventoryScript>().item1 = "lighter";
                    inventory.GetComponent<InventoryScript>().amount1++;
                    Destroy(hit.transform.parent.gameObject);
                }
            }
        }

        if (inventory.GetComponent<InventoryScript>().item1 == "lighter" && inventory.GetComponent<InventoryScript>().amount1 > 0 && inventory.GetComponent<InventoryScript>().pie1)
        {
            RaycastHit hit2;
            if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit2, 2))
            {
                if (hit.transform.name == "Candle" && hit.transform.Find("Flame").gameObject.activeInHierarchy == false)
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        source.PlayOneShot(lighter);
                        hit.transform.Find("Flame").gameObject.SetActive(true);
                        litCandles++;
                        if (litCandles == 8)
                        {
                            source.PlayOneShot(summon);
                            started = true;
                        }
                    }
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (started)
        {
            time--;
            if (time == 0)
            {
                black.SetActive(true);
                animator.Play("Blackout", 0);
            }
            if (time == -150)
            {
                SceneManager.LoadScene("Cutscene3");
            }
        }
    }
}
