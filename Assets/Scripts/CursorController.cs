using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{


    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    // void OnMouseEnter()
    // {
    //     Cursor.SetCursor(null, Vector2.zero, cursorMode);
    // }

    // void OnMouseExit()
    // {
    //     Cursor.SetCursor(null, Vector2.zero, cursorMode);
    // }

}
