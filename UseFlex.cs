using UnityEngine;

public class UseFlex : MonoBehaviour
{
    public Camera playerCam;
    public GameObject use;
    public GameObject flex;
    public GameObject sparks;
    public GameObject flexOn;
    public GameObject flexOff;
    public GameObject flexWind;
    public LayerMask mask;

    public AudioClip flex_start;
    public AudioClip flex_end;
    public AudioSource cutting;
    public Animator flexAnimator;

    int idleDelay = 0;


    void Update()
    {
        if (transform.GetComponent<FlexScript>().hasFlex)
        {
            use.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                flexAnimator.Play("flex_shake", 0);
                flexWind.SetActive(true);
                flexOff.SetActive(false);
                flexOn.SetActive(true);
                transform.GetComponent<AudioSource>().PlayOneShot(flex_start);
                idleDelay = 200;
            }
            if (Input.GetMouseButtonUp(0))
            {
                flexAnimator.Play("idle", 0);
                flexWind.SetActive(false);
                flexOff.SetActive(true);
                flexOn.SetActive(false);
                idleDelay = 0;
                transform.GetComponent<AudioSource>().Stop();
                transform.GetComponent<AudioSource>().PlayOneShot(flex_end);
                flex.GetComponent<AudioSource>().enabled = false;
            }
            RaycastHit hit;
            if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
            {
                if (hit.transform.name == "Bars")
                {
                    if (Input.GetMouseButton(0))
                    {
                        cutting.enabled = true;
                        sparks.SetActive(true);
                        sparks.transform.position = new Vector3(hit.point.x - 0.2f, hit.point.y, hit.point.z); ;
                    } else
                    {
                        cutting.enabled = false;
                        sparks.SetActive(false);
                    }
                }
            } else
            {
                cutting.enabled = false;
                sparks.SetActive(false);
            }
        }
    }

    void FixedUpdate()
    {
        if (transform.GetComponent<FlexScript>().hasFlex) {
        RaycastHit hit;
            if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
            {
                if (hit.transform.name == "Bars")
                {
                    if (Input.GetMouseButton(0))
                    {
                        hit.transform.GetComponent<BarsLifetime>().lifetime--;
                    }
                }
            }
        }

        idleDelay--;
        if (idleDelay == 1)
        {
            flex.GetComponent<AudioSource>().enabled = true;
        }
    }
}
