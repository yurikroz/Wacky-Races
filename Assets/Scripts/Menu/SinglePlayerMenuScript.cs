using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SinglePlayerMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

    // On "No" button pressed in Quit menu
    public void StartLevel(int level)
    {
        Application.LoadLevel(level);
    }
	
}
