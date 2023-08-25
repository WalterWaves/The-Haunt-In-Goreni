using UnityEngine;

public class TigaieCollision : MonoBehaviour
{
    public GameObject glassParticles;
    public GameObject piranda;
    public AudioSource source;
    public AudioClip clip;
    public AudioClip metal1;
    public AudioClip metal2;
    public AudioClip metal3;
    public AudioClip metal4;
    public AudioClip metal5;
    public AudioClip metal6;
    public AudioClip metal7;

    void Update()
    {
        if (transform.localPosition.y <= -10)
        {
            transform.localPosition = new Vector3(-6.1275f, 0.30125f, 12.4437f);
            transform.localRotation = Quaternion.Euler(new Vector3(0, -82.1f, 0));
            transform.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        int r = Random.Range(1, 8);
        if (r == 1)
        {
            transform.GetComponent<AudioSource>().PlayOneShot(metal1);
        }
        if (r == 2)
        {
            transform.GetComponent<AudioSource>().PlayOneShot(metal2);
        }
        if (r == 3)
        {
            transform.GetComponent<AudioSource>().PlayOneShot(metal3);
        }
        if (r == 4)
        {
            transform.GetComponent<AudioSource>().PlayOneShot(metal4);
        }
        if (r == 5)
        {
            transform.GetComponent<AudioSource>().PlayOneShot(metal5);
        }
        if (r == 6)
        {
            transform.GetComponent<AudioSource>().PlayOneShot(metal6);
        }
        if (r == 7)
        {
            transform.GetComponent<AudioSource>().PlayOneShot(metal7);
        }

        if (collision.gameObject.name == "AragazGlass")
        {
            piranda.SetActive(true);
            piranda.GetComponent<PirandaScript>().awake = true;
            Destroy(collision.gameObject);
            glassParticles.SetActive(true);
            source.PlayOneShot(clip);
            AragazScript.aragazBroken = true;
        }
    }
}
