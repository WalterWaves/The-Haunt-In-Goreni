using UnityEngine;

public class DrawerScript : MonoBehaviour
{
    public Camera playerCam;
    public GameObject interact;
    public AudioSource source;
    public AudioClip clip;
    public Animator paperAnimator;

    int cooldownTime = 0;

    void Update()
    {
        if (cooldownTime == 0)
        {
            RaycastHit hit;
            if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 2))
            {
                if (hit.transform.name == "Drawer1")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer1Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        } else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer1Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer2")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer2Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer2Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer3")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer3Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer3Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer4Paper")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer4Close", 0);
                            paperAnimator.Play("PaperMoveClose", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer4Open", 0);
                            paperAnimator.Play("PaperMoveOpen", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer4")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer4Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer4Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer5")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer5Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer5Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer6")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer6Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer6Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer7")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer7Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer7Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer8")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer8Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer8Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer9")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer9Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer9Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer10")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer10Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer10Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer11")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer11Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer11Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }

                if (hit.transform.name == "Drawer12")
                {
                    interact.SetActive(true);
                    if (Input.GetKeyDown("e"))
                    {
                        if (hit.transform.GetComponent<DrawerState>().open)
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer12Close", 0);
                            hit.transform.GetComponent<DrawerState>().open = false;
                        }
                        else
                        {
                            hit.transform.GetComponent<Animator>().Play("Drawer12Open", 0);
                            hit.transform.GetComponent<DrawerState>().open = true;
                        }
                        cooldownTime = 50;
                        source.PlayOneShot(clip);
                    }
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (cooldownTime > 0)
        {
            cooldownTime--;
        }
    }
}
