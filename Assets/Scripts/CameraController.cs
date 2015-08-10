using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
    // Guaranteed to be called right after all other game objects finished their moving per a frame
    //
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
