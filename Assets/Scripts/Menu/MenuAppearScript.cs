using UnityEngine;
using System.Collections;

public class MenuAppearScript : MonoBehaviour
{

    public GameObject menu; // Assign in inspector
    public bool isShowing;

    public void Start()
    {
        isShowing = false;
        menu.SetActive(isShowing);
    }

    public void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
        }
    }
}
