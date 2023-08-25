using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarsLifetime : MonoBehaviour
{
    public int lifetime = 150;
    public AudioSource source;
    public AudioClip clip;
    void Update()
    {
        if (lifetime <= 0)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(100, 0, 0));
            source.PlayOneShot(clip);
            lifetime = 999999;
        }
    }
}
