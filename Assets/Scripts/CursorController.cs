using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{


    public Texture2D inPlayCursor;
    public Texture2D menuCursor;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        Cursor.SetCursor(inPlayCursor, hotSpot, cursorMode);
    }

    void OnMouseEnter()
    {
       if (gameObject.tag == "UI") {
            Cursor.SetCursor(menuCursor, hotSpot, cursorMode);
       }
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(inPlayCursor, hotSpot, cursorMode);
    }

}
