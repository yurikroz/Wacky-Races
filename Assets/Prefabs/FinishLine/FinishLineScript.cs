using UnityEngine;
using System.Collections;
using Assets.Scripts;
using UnityEngine.UI;

public class FinishLineScript : MonoBehaviour {

    public Canvas message;
    public Text textMessage;

	// Use this for initialization
	void Start () {
        //message.gameObject.SetActive(false);
        message.GetComponent<Canvas>().enabled = false;
	}

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("FinishLine Collider: Activated!");

        string mode = PlayerPrefs.GetString(Globals.GamePrefs.GameMode.ToString());

        if (mode == Globals.GameMode.SinglePlayer.ToString())
        { // Singleplayer
            //message.gameObject.SetActive(true);
            
            Debug.Log("FinishLine collider tag: " + collider.gameObject.tag);

            if (collider.gameObject.tag == Globals.Tags.Player.ToString())
            {
                message.GetComponent<Canvas>().enabled = true;
                textMessage.text = "You win!";
                GetComponent<BoxCollider>().isTrigger = false;
                gameObject.SetActive(false);
            }
            else if (collider.gameObject.tag == Globals.Tags.Car.ToString())
            {
                message.GetComponent<Canvas>().enabled = true;
                textMessage.text = "You loose!";
                gameObject.SetActive(false);
            }
            
            //message.GetComponent<Canvas>().gameObject.SetActive(true);
        }
        else
        { // Multiplayer

        }
    }
}
