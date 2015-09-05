using UnityEngine;
using System.Collections;
using Assets.Scripts;
public class GameController : MonoBehaviour {
    string mode;

    public GameObject playerCar;
    public GameObject AICar;
    public GameObject networkManager;
	// Use this for initialization
	void Start () {
        if (!string.IsNullOrEmpty(Globals.GamePrefs.GameMode.ToString()))
            mode = PlayerPrefs.GetString(Globals.GamePrefs.GameMode.ToString());
        
        //////////////////////////for debug only!!!
        //mode = Globals.GameMode.SinglePlayer.ToString();
        //////////////////////////for debug only!!!
        Debug.Log("Mode: " + mode);
        if (mode == Globals.GameMode.SinglePlayer.ToString())
        {
            playerCar.SetActive(true);
            AICar.SetActive(true);
            networkManager.SetActive(false);
        }
        else //multiplayer
        {
            playerCar.SetActive(false);
            AICar.SetActive(false);
            networkManager.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
