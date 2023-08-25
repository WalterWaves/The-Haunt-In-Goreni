using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public bool pie1 = false;
    public bool pie2 = false;
    public bool pie3 = false;
    public bool pie4 = false;

    public string item1 = "";
    public string item2 = "";
    public string item3 = "";
    public string item4 = "";
    public GameObject item1Object;
    public GameObject item2Object;
    public GameObject item3Object;
    public GameObject item4Object;

    public int amount1 = 0;
    public int amount2 = 0;
    public int amount3 = 0;
    public int amount4 = 0;
    public GameObject amount1Object;
    public GameObject amount2Object;
    public GameObject amount3Object;
    public GameObject amount4Object;
    void Update()
    {
        if (amount1 > 0 && (item1 == "firecracker" || item1 == "lighter"))
        {
            amount1Object.GetComponent<TMPro.TextMeshProUGUI>().text = amount1.ToString();
            item1Object.SetActive(true);

        } else
        {
            amount1Object.GetComponent<TMPro.TextMeshProUGUI>().text = "";
            item1Object.SetActive(false);
        }

        if (amount2 > 0)
        {
            amount2Object.GetComponent<TMPro.TextMeshProUGUI>().text = amount2.ToString();
        }
        else
        {
            amount2Object.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        }

        if (amount3 > 0)
        {
            amount3Object.GetComponent<TMPro.TextMeshProUGUI>().text = amount3.ToString();
        }
        else
        {
            amount3Object.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        }

        if (amount4 > 0)
        {
            amount4Object.GetComponent<TMPro.TextMeshProUGUI>().text = amount4.ToString();
        }
        else
        {
            amount4Object.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        }

        if (Input.GetKeyDown("1") && !pie1)
        {
            source.PlayOneShot(clip);
            pie1 = true;
            transform.GetComponent<Animator>().Play("inv_pie1", 0);
            pie2 = false;
            pie3 = false;
            pie4 = false;
        }

        if (Input.GetKeyDown("2") && !pie2)
        {
            source.PlayOneShot(clip);
            pie2 = true;
            transform.GetComponent<Animator>().Play("inv_pie2", 0);
            pie1 = false;
            pie3 = false;
            pie4 = false;
        }

        if (Input.GetKeyDown("3") && !pie3)
        {
            source.PlayOneShot(clip);
            pie3 = true;
            transform.GetComponent<Animator>().Play("inv_pie3", 0);
            pie1 = false;
            pie2 = false;
            pie4 = false;
        }

        if (Input.GetKeyDown("4") && !pie4)
        {
            source.PlayOneShot(clip);
            pie4 = true;
            transform.GetComponent<Animator>().Play("inv_pie4", 0);
            pie1 = false;
            pie3 = false;
            pie2 = false;
        }
    }
}
