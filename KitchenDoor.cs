using UnityEngine;

public class KitchenDoor : MonoBehaviour
{
    public GameObject kitchenDoor;

    void Update()
    {
        if (transform.GetComponent<DrawerState>().open)
        {
            kitchenDoor.transform.localPosition = new Vector3(0.55f, 0.96f, 6.45f);
            kitchenDoor.transform.localRotation = Quaternion.Euler(0, 270, 0);
        }
    }
}
