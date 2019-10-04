using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMouse : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        faceMouse();
    }

    private void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition; // Get Mouse's Position in Screen Space
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); // Converts the 2D position of the mouse into a 3D position

        Vector2 direction = new Vector2( // Subtracts the Players position from the mouse's position
            mousePosition.x - transform.position.x, 
            mousePosition.y - transform.position.y
        );

        transform.up = direction; // Sets the direction that the Player should be facing the mouse
    }
}
