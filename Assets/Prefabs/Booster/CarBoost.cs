using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class CarBoost : MonoBehaviour {

	// Use this for initialization
    public float boostMagnitude = 0.0f;
    public float boostEffectLength = 1.0f;
    public bool active = true;

	void Start () {
        Debug.Log(this.gameObject.tag + " has been initialized!");
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.CompareTag("Car") || other.gameObject.CompareTag("Player")) && active)
        {
            active = false;
            StartCoroutine(BoostCar(other.gameObject));
            MeshRenderer render = this.gameObject.GetComponentInChildren<MeshRenderer>();
            render.enabled = false;
        }
    }

    public IEnumerator BoostCar(GameObject playerCar) 
    {
        // Increase a player's car speed
        playerCar.GetComponent<CarController>().CurrentSpeed = boostMagnitude;

        yield return new WaitForSeconds(boostEffectLength);

        playerCar.GetComponent<CarController>().CurrentSpeed = -boostMagnitude;

        this.gameObject.SetActive(false);
    }
}
