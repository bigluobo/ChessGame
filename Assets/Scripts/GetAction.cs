using UnityEngine;
using System.Collections;

public class GetAction : MonoBehaviour {

    void OnMouseUp()
    {
        if (gameObject.name == "Attack Button") {
            Debug.Log("Setting action");
            GameController.action = 1;
        } else if (gameObject.name == "Move Button")
        {
            GameController.action = 2;
        } else if (gameObject.name == "Special Button")
        {
            GameController.action = 3;
        } else {
            GameController.action = 0;
        }
    }
}
