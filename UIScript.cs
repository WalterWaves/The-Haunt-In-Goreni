using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public bool menu = false;
    public GameObject menuObject;
    public GameObject black;
    public GameObject settingsUI;
    public GameObject interact;
    public GameObject throwItem;
    public GameObject inventory;

    bool settingsOpen = false;
    bool isOpen = false;
    int blackTicks = 0;
    void Update()
    {
        if (Input.GetKeyDown("escape") && isOpen == false)
        {
            menu = !menu;
            if (menu)
            {
                black.SetActive(true);
                menuObject.SetActive(true);
                menuObject.GetComponent<Animator>().Play("BigMenuOpen", 0);
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
                transform.GetComponent<FirstPersonController>().lockCursor = false;
                transform.GetComponent<FirstPersonController>().cameraCanMove = false;
                inventory.GetComponent<Animator>().Play("hide_inventory", 0);
            } else
            {
                isOpen = true;
                blackTicks = 0;
                menuObject.GetComponent<Animator>().Play("BigMenuClose", 0);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                transform.GetComponent<FirstPersonController>().lockCursor = true;
                transform.GetComponent<FirstPersonController>().cameraCanMove = true;
                inventory.GetComponent<Animator>().Play("show_inventory", 0);
            }
        }
    }

    void FixedUpdate()
    {
        interact.SetActive(false);
        throwItem.SetActive(false);

        if (isOpen)
        {
            blackTicks++;
            if (blackTicks >= 100)
            {
                isOpen = false;
                blackTicks = 0;
                black.SetActive(false);
                menuObject.SetActive(false);
            }
        }
    }

    public void BackToGame()
    {
        isOpen = true;
        blackTicks = 0;
        menuObject.GetComponent<Animator>().Play("BigMenuClose", 0);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        transform.GetComponent<FirstPersonController>().lockCursor = true;
        transform.GetComponent<FirstPersonController>().cameraCanMove = true;
        menu = false;
        inventory.GetComponent<Animator>().Play("show_inventory", 0);
    }

    public void BackToMainMenu()
    {
        Loading.destination = "Menu";
        SceneManager.LoadScene("LoadingScreen");
    }

    public void SettingsButton()
    {
        settingsOpen = !settingsOpen;
        if (settingsOpen)
        {
            settingsUI.transform.GetComponent<Animator>().Play("SettingsOpen", 0);
        }
        else
        {
            settingsUI.transform.GetComponent<Animator>().Play("SettingsClose", 0);
        }
    }

    public void Retry()
    {
        Loading.destination = "Main";
        SceneManager.LoadScene("LoadingScreen");
    }
}
