using UnityEngine;
using System.Collections;

public class ChessPieceController : MonoBehaviour {

    void OnMouseDown()
    {
        ActionWheelController.displayActionWheel = true;
    }

    void OnMouseUp()
    {
        //hide action wheel and call corresponding functions depending on the action
        ActionWheelController.displayActionWheel = false;

        GameController.Action();
    }
}
