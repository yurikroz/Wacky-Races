using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {
   
    // Main menu
    public Button singlePlayerText;
    public Button multiplayerText;
    public Button aboutText;
    public Button exitText;

    // Single player menu
    public Canvas singlePlayerMenu;

    // Multiplayer menu
    public Canvas multiplayerMenu;
    public Button startMultiplayerScene1;
    public Button startMultiplayerScene2;
    public Button startMultiplayerScene3;

    // About menu
    public Canvas aboutMenu;

    // Quit menu
    public Canvas quitMenu;

	// Use this for initialization
	void Start () {
        // Main menu
        singlePlayerText = singlePlayerText.GetComponent<Button>();
        multiplayerText = multiplayerText.GetComponent<Button>();
        aboutText = aboutText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();

        // Single player menu
        singlePlayerMenu = singlePlayerMenu.GetComponent<Canvas>();
        singlePlayerMenu.enabled = false;

        // Multiplayer menu
        multiplayerMenu = multiplayerMenu.GetComponent<Canvas>();
        multiplayerMenu.enabled = false;

        // About menu
        aboutMenu = aboutMenu.GetComponent<Canvas>();
        aboutMenu.enabled = false;

        // Quit menu
        quitMenu = quitMenu.GetComponent<Canvas>();
        quitMenu.enabled = false;
	}
	
	// On "Exit" button pressed
	public void ExitPress() {
        // Show "Quit" menu
        singlePlayerMenu.enabled = false;
        multiplayerMenu.enabled = false;
        aboutMenu.enabled = false;
        quitMenu.enabled = true;

        // Disable main menu buttons
        singlePlayerText.enabled = false;
        multiplayerText.enabled = false;
        aboutText.enabled = false;
        exitText.enabled = false;
	}

    // On "About" button pressed
    public void AboutPress()
    {
        singlePlayerMenu.enabled = false;
        multiplayerMenu.enabled = false;
        aboutMenu.enabled = true;
        quitMenu.enabled = false;
    }

    // On "Single Player" button pressed
    public void SinglePlayerPress()
    {
        singlePlayerMenu.enabled = true;
        multiplayerMenu.enabled = false;
        aboutMenu.enabled = false;
        quitMenu.enabled = false;
    }

    // On "Multiplayer" button pressed
    public void MultiplayerPress()
    {
        singlePlayerMenu.enabled = false;
        multiplayerMenu.enabled = true;
        aboutMenu.enabled = false;
        quitMenu.enabled = false;
    }

    // On "No" button pressed in Quit menu
    public void NoPress()
    {
        // Show "Quit" menu
        quitMenu.enabled = false;

        // Disable main menu buttons
        singlePlayerText.enabled = true;
        multiplayerText.enabled = true;
        aboutText.enabled = true;
        exitText.enabled = true;
    }

    // On "Yes" button pressed in Quit menu
    public void ExitGame()
    {
        Application.Quit();
    }
}
