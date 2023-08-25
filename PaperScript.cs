using UnityEngine;

public class PaperScript : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public Animator paperBlackAnimator;
    public GameObject paperBlack;
    public Animator paperAnimator;
    public GameObject paper;
    public Animator physicalPaper;
    public AudioSource source;
    public AudioClip clip;

    bool isReading = false;
    bool picked = false;
    int delay = 50;

    void Update()
    {
        if (isReading)
        {
            if (Input.GetMouseButton(0))
            {
                transform.GetComponent<FirstPersonController>().cameraCanMove = true;
                transform.GetComponent<FirstPersonController>().playerCanMove = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                paperBlack.SetActive(false);
                paper.SetActive(false);
                isReading = false;
                physicalPaper.Play("PaperPutDown", 0);
                source.PlayOneShot(clip);
            }
        }

        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
        {
            if (hit.transform.name == "Paper")
            {
                interact.SetActive(true);
                if (Input.GetKeyDown("e"))
                {
                    hit.transform.parent.GetComponent<Animator>().Play("PaperPickup", 0);
                    source.PlayOneShot(clip);
                    picked = true;
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (picked)
        {
            delay--;
            if (delay <= 0)
            {
                picked = false;
                delay = 50;
                transform.GetComponent<FirstPersonController>().cameraCanMove = false;
                transform.GetComponent<FirstPersonController>().playerCanMove = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;
                paperBlack.SetActive(true);
                paperBlackAnimator.Play("PaperBlack", 0);
                paper.SetActive(true);
                paperAnimator.Play("PaperUI", 0);
                isReading = true;
            }
        }
    }
}
