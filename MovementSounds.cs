using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSounds : MonoBehaviour
{
    public AudioClip footsteps1;
    public AudioClip footsteps2;
    public AudioClip footsteps3;
    public AudioClip footsteps4;
    public Camera playerCam;

    int ticks = 0;

    void FixedUpdate()
    {
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            if (playerCam.fieldOfView > 60)
            {
                playerCam.fieldOfView--;
            }
        }

        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            ticks++;
            if (ticks >= 50)
            {
                ticks = 0;
                int r = Random.Range(1, 5);
                if (r == 1)
                {
                    transform.GetComponent<AudioSource>().PlayOneShot(footsteps1);
                }
                if (r == 2)
                {
                    transform.GetComponent<AudioSource>().PlayOneShot(footsteps2);
                }
                if (r == 3)
                {
                    transform.GetComponent<AudioSource>().PlayOneShot(footsteps3);
                }
                if (r == 4)
                {
                    transform.GetComponent<AudioSource>().PlayOneShot(footsteps4);
                }
            }
        }
    }
}
