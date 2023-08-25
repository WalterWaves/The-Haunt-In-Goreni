using UnityEngine;
using UnityEngine.AI;

public class PirandaScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera playerCam;
    public GameObject player;
    public GameObject sleepyPiranda;
    public GameObject stunnedObject;
    public GameObject ui;
    public GameObject flex;
    public GameObject menu;
    public bool stunned = false;
    public bool awake = false;
    public bool playerDead = false;
    public int stunTime;
    public Animator blackoutAnimator;
    public Animator youDiedAnimator;
    public Animator buttonsAnimator;
    public AudioSource source;
    public AudioClip clip;
    int deathDelay = 200;

    void Awake()
    {
        stunTime = 600;
    }

    void Update()
    {
        if (awake)
        {
            sleepyPiranda.SetActive(false);
            if (!stunned)
            {
                if ((player.transform.position - transform.position).magnitude <= 1.75)
                {
                    agent.velocity = new Vector3(0, 0, 0);
                    player.transform.LookAt(transform);
                    playerCam.transform.localRotation = Quaternion.Euler(new Vector3(-40, 0, 0));
                    player.GetComponent<FirstPersonController>().cameraCanMove = false;
                    player.GetComponent<FirstPersonController>().playerCanMove = false;
                    player.GetComponent<FirstPersonController>().fov = 50;
                    playerCam.fieldOfView = 50;
                    transform.GetComponent<Animator>().Play("JumpScare", 0);
                    ui.SetActive(false);
                    flex.SetActive(false);
                    playerDead = true;
                }
                else
                {
                    agent.SetDestination(player.transform.position);
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (playerDead)
        {
            menu.SetActive(false);
            if(deathDelay == 200)
            {
                source.PlayOneShot(clip);
                player.GetComponent<CapsuleCollider>().enabled = false;
                player.GetComponent<Rigidbody>().useGravity = false;
                player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.25f, player.transform.position.z);
            }
            deathDelay--;
            if (deathDelay == 0)
            {
                blackoutAnimator.Play("Blackout", 0);
            }
            if (deathDelay == -150)
            {
                youDiedAnimator.Play("YouDied", 0);
            }
            if (deathDelay == -250)
            {
                buttonsAnimator.Play("Buttons", 0);
            }
            if (deathDelay == -300)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;
            }
        }

        if (stunned && awake)
        {
            stunnedObject.SetActive(true);
            if (stunTime == 600)
            {
                transform.GetComponent<Animator>().Play("Stunned", 0);
            }
            agent.SetDestination(transform.position);
            stunTime--;
            if (stunTime <= 0)
            {
                stunnedObject.SetActive(false);
                transform.GetComponent<Animator>().Play("Walking", 0);
                stunned = false;
                stunTime = 600;
            }
        }
    }
}
