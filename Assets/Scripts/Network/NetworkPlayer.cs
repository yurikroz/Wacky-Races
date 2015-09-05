using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class NetworkPlayer : Photon.MonoBehaviour {
    public GameObject Camera;
	// Use this for initialization
	void Start () {
        if (photonView.isMine) //local car
        {
            Camera.SetActive(true);
            //Camera.se
            GetComponentInChildren<CarUserControl>().ControlEnabled = true;
            GetComponentInChildren<Camera>().enabled = true;
            GetComponentInChildren<Rigidbody>().useGravity = true;
            GetComponentInChildren<PlayerController>().enabled = true;
        }
        else
        {
            GetComponentInChildren<CarController>().enabled = false;
            Debug.Log("NetworkPlayer car controller disabled");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
