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
            GetComponent<CarUserControl>().ControlEnabled = true;
            GetComponentInChildren<Camera>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<PlayerController>().enabled = true;
        }
        else
        {
            GetComponent<CarController>().enabled = false;
            Debug.Log("NetworkPlayer car controller disabled");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
