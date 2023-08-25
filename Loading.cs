using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{

    public static string destination;
    public string tip;
    public int ticks = 0;
    public GameObject tipObject;

    void Start()
    {
        int r = Random.Range(1, 11);
        if (r == 1)
        {
            tip = "Wearing headphones may improve your gaming experience.";
        }
        if (r == 2)
        {
            tip = "This game contains flashing lights and loud sounds.";
        }
        if (r == 3)
        {
            tip = "Your flashlight may short out from time to time.";
        }
        if (r == 4)
        {
            tip = "You may not be alone.";
        }
        if (r == 5)
        {
            tip = "Always watch behind you.";
        }
        if (r == 6)
        {
            tip = "Some things may not be what they seem.";
        }
        if (r == 7)
        {
            tip = "Sometimes running is the only option.";
        }
        if (r == 8)
        {
            tip = "Firecrackers spawn in random parts of the map.";
        }
        if (r == 9)
        {
            tip = "Try using the items you find in your advantage.";
        }
        if (r == 10)
        {
            tip = "This game requires fast reaction time.";
        }
        tipObject.GetComponent<TMPro.TextMeshProUGUI>().text = tip;
        tip = "";
    }

    void FixedUpdate()
    {
        ticks++;
        if (ticks >= 250)
        {
            SceneManager.LoadScene(destination);
        }
    }
}
