using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using Assets.Scripts;

public class NetworkPlayer : Photon.MonoBehaviour {
    public GameObject Camera;
	// Use this for initialization
	void Start () {
        string  gameMode = PlayerPrefs.GetString(Globals.GamePrefs.GameMode.ToString());
        if (gameMode == Globals.GameMode.MultiPlayer.ToString())
        {
            if (photonView.isMine) //local car
            {
                Camera.SetActive(true);
                //Camera.se
                GetComponent<CarUserControl>().ControlEnabled = true;
                GetComponentInChildren<Camera>().enabled = true;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<PlayerController>().enabled = true;
            }
            else
            {
                GetComponent<CarController>().enabled = false;
                gameObject.SetActive(true);
                Debug.Log("NetworkPlayer car controller disabled");
            }
        }
        else
        {
            //
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
