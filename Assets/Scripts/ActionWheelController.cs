using UnityEngine;
using System.Collections;

public class ActionWheelController : MonoBehaviour {

    public static bool displayActionWheel;
    GameObject wheel;

    // Use this for initialization
    void Start () {
        displayActionWheel = false;
        wheel = gameObject.transform.Find("Buttons").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (displayActionWheel)
        {
            wheel.SetActive(true);
        }
        else {
            wheel.SetActive(false);
        }
	}
}
