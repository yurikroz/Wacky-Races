using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseGameMenuScript : MonoBehaviour
{

    public Canvas pauseMenu;

    public void Start()
    {
        pauseMenu = pauseMenu.GetComponent<Canvas>();
        pauseMenu.enabled = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            pauseMenu.enabled = !pauseMenu.enabled;
            //menu.SetActive(isShowing);
        }
    }

    public void ReturnToMainMenu()
    {
        Application.LoadLevel(0);
    }

    public void Cancel()
    {
        pauseMenu.enabled = false;
    }
}
