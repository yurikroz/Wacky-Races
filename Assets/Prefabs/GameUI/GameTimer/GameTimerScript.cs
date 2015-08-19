using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimerScript : MonoBehaviour {

    public float timePassed = 0f;
    public Text timerText;
    public bool isActive = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isActive)
        { 
            timePassed += Time.deltaTime;
            updateTimerText();
        }
	}

    private void updateTimerText()
    {
        float minutes = Mathf.Floor(timePassed / 60);
        float seconds = Mathf.RoundToInt(timePassed) % 60;
        float milliseconds = Mathf.RoundToInt(Mathf.Abs(timePassed - seconds) * 100);

        if (minutes < 10)
        {
            timerText.text = "0" + minutes.ToString() + " : ";
        }
        else
        {
            timerText.text = minutes.ToString() + " : ";
        }

        if (seconds < 10)
        {
            timerText.text += "0" + seconds.ToString() + ".";
        }
        else
        {
            timerText.text += seconds.ToString() + ".";
        }

        if (milliseconds < 10)
        {
            timerText.text += "0" + milliseconds.ToString();
        } else {
            timerText.text += milliseconds.ToString();
        }
    }
}
