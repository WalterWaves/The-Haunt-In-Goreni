using UnityEngine;

public class Firecracker_Spawn : MonoBehaviour
{
    void Start()
    {
        int r = Random.Range(1, 10);
        if (r != 1)
        {
            Destroy(gameObject);
        }
    }
}
