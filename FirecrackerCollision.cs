using UnityEngine;

public class FirecrackerCollision : MonoBehaviour
{
    public GameObject explosionObject;
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        if (transform.localPosition.y <= -10)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name != "FirstPersonController")
        {
            if (collision.transform.name == "Piranda")
            {
                collision.transform.GetComponent<PirandaScript>().stunned = true;
            }
            GameObject explosion = Instantiate(explosionObject);
            explosion.transform.localPosition = transform.localPosition;
            explosion.SetActive(true);
            source.PlayOneShot(clip);
            Destroy(transform.gameObject);
        }
    }
}
