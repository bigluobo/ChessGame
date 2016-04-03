using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class GameController : MonoBehaviour {
    public static int action;

    // Use this for initialization
    void Start () {
        action = 0;
	}
	
    void FixedUpdate()
    {
        //Detect selections on the action wheel
        RaycastHit2D hit = Physics2D.Raycast(Input.mousePosition, Vector2.zero);

        if (hit)
        {
            string hitName = hit.transform.gameObject.name;
            if (hitName == "Attack Button")
            {
                action = 1;
            } else if (hitName == "Move Button")
            {
                GameController.action = 2;
            }
            else if (hitName == "Special Button")
            {
                GameController.action = 3;
            }
        } else
        {
            action = 0;
        }
    }

    public static void Action()
    {
        //call corresponding functions depending on the action
        switch (action)
        {
            case 1:
                Debug.Log("Attack!");
                break;
            case 2:
                Debug.Log("Move!");
                break;
            case 3:
                Debug.Log("Special!");
                break;
            default:
                Debug.Log("Nothing!");
                break;
        }
    }
}