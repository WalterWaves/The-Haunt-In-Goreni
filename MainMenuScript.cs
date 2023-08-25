using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Camera cam;
    public LayerMask mask;
    public GameObject play;
    public GameObject quit;
    public GameObject blackScreen;
    public AudioClip menu_sound;
    public AudioClip woosh;
    public GameObject userSettings;
    public AudioClip click;

    bool played1 = false;
    bool played3 = false;

    bool pressedPlay = false;
    int playTicks = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.GetComponent<AudioSource>().PlayOneShot(click);
        }

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = cam.ScreenToWorldPoint(mousePos);

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100, mask))
        {
            if (hit.transform.name == "Play")
            {
                if (!played1)
                {
                    transform.GetComponent<AudioSource>().PlayOneShot(menu_sound);
                    played1 = true;
                }
                play.GetComponent<TMPro.TextMeshPro>().color = Color.red;
                
                if (Input.GetMouseButtonDown(0))
                {
                    transform.GetComponent<AudioSource>().PlayOneShot(woosh);
                    blackScreen.GetComponent<Animator>().Play("blackScreen", 0);
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    pressedPlay = true;
                }
            } else
            {
                played1 = false;
            }
            if (hit.transform.name == "Quit")
            {
                if (!played3)
                {
                    transform.GetComponent<AudioSource>().PlayOneShot(menu_sound);
                    played3 = true;
                }
                quit.GetComponent<TMPro.TextMeshPro>().color = Color.red;

                if (Input.GetMouseButtonDown(0))
                {
                    Application.Quit();
                }
            } else
            {
                played3 = false;
            }
        }
    }

    void FixedUpdate()
    {
        play.GetComponent<TMPro.TextMeshPro>().color = Color.white;
        quit.GetComponent<TMPro.TextMeshPro>().color = Color.white;

        if (pressedPlay)
        {
            playTicks++;
            if (playTicks >= 250)
            {
                pressedPlay = false;
                playTicks = 0;
                Loading.destination = "Cutscene1";
                DontDestroyOnLoad(userSettings);
                SceneManager.LoadScene("LoadingScreen");
            }
        }
    }
}
