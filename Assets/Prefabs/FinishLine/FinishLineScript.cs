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

        if (mode == Globals.GameMode.SinglePlayer.ToString() 
            && (collider.gameObject.tag == Globals.Tags.Player.ToString() || collider.gameObject.tag == Globals.Tags.Car.ToString()))
        { // Singleplayer
            //message.gameObject.SetActive(true);
            
            Debug.Log("FinishLine collider tag: " + collider.gameObject.tag);

            if (collider.gameObject.tag == Globals.Tags.Player.ToString())
            {
                message.gameObject.SetActive(true);
                message.GetComponent<Canvas>().enabled = true;
                textMessage.text = "You win!";
                GetComponent<BoxCollider>().isTrigger = false;
                gameObject.SetActive(false);
            }
            else
            {
                message.gameObject.SetActive(true);
                message.GetComponent<Canvas>().enabled = true;
                textMessage.text = "You loose!";
                gameObject.SetActive(false);
            }
            
            //message.GetComponent<Canvas>().gameObject.SetActive(true);
        }
        else
        { // Multiplayer
            if(collider.gameObject.GetComponent<PhotonView>().viewID !=0)
            {
                Debug.Log("is mine: " + collider.gameObject.GetPhotonView().viewID);

            }
            if (collider.gameObject.GetPhotonView().isMine)
            {
                message.gameObject.SetActive(true);
                message.GetComponent<Canvas>().enabled = true;
                textMessage.text = "You win!";
                GetComponent<BoxCollider>().isTrigger = false;
                gameObject.SetActive(false);
            }
            else
            {
                message.gameObject.SetActive(true);
                message.GetComponent<Canvas>().enabled = true;
                textMessage.text = "You loose!";
                gameObject.SetActive(false);
            }
        }
    }
}
