using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts;

public class WinLooseMessageScript : MonoBehaviour {

    public Canvas winLooseMenu;

    public void Start()
    {
        winLooseMenu = winLooseMenu.GetComponent<Canvas>();
        winLooseMenu.enabled = false;
    }

    public void ReturnToMainMenu()
    {
        if(PlayerPrefs.GetString(Globals.GamePrefs.GameMode.ToString()).Equals(Globals.GameMode.MultiPlayer.ToString()))
        {
            PhotonNetwork.DestroyPlayerObjects(PhotonNetwork.player);
            Debug.Log("leaving the room");
        }
        Application.LoadLevel(0);
    }
}