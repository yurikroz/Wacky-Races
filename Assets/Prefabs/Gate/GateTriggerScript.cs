using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class GateTriggerScript : MonoBehaviour
{

    Animator animator;
    bool gateOpen;
    bool active;

    void Start()
    {
        active = true;
        gateOpen = false;
        animator = GetComponentInParent<Animator>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<CarController>() != null && active)
        {
            Debug.Log("GateTriggerScript: Collision with a car has been detected");
            gateOpen = true;
            OpenGate();
        }
    }

    void OpenGate()
    {
        animator.SetTrigger("Open");
        Debug.Log("Gate trigger set to \"Open\"");
    }
}

