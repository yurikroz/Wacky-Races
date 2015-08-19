using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class RaceStartCountdownScript : MonoBehaviour
{
    public GameTimerScript gameTimer;
    public CarUserControl[] cars;
    public Text counterText;
    private float counter = 0;
    private string[] counterTextValues = {"3", "2", "1", "GO!"};

	// Use this for initialization
	void Start () {
        gameTimer.isActive = false;
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].ControlEnabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (counter >= counterTextValues.Length)
        {
            counterText.gameObject.SetActive(false);
            gameTimer.isActive = true;
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].ControlEnabled = true;
            }
        }
        else
        {
            counterText.text = counterTextValues[Mathf.RoundToInt(Mathf.Floor(counter))];
            counter += Time.deltaTime;
        }
	}
}
