using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // A reference to the game object's rigidbody component
    private Rigidbody rb;
    public Text scoreText;
    //public GameObject scoreText;
    private int score = 0;
    const int winScore = 12;

    // Called only once when the script is attached to an object
    //
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetCountText();
    }

	// Update is called once per frame
	void Update () {}

    // Called beforeperforming any physics calculations 
    // This is where our physics code will go
    void FixedUpdate()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score++;
            SetCountText();
        }
        //Destroy(other.gameObject);
    }

    void SetCountText()
    {
        GetComponentInChildren<Text>().text = "Score: " + score.ToString();
        if (score >= winScore)
        {
            GetComponentInChildren<Text>().text = "You win!";
        }
    }
}
