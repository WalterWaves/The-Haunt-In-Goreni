using UnityEngine;

public class WoodCollision : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        if (transform.position.y <= -10)
        {
            transform.position = new Vector3(5.55f, 3, -1.3f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        source.PlayOneShot(clip);
    }
}
