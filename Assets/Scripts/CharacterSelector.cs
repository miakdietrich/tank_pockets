using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    private GameObject[] characterList;
    private int index = 0;

    // Start is called before the first frame update
    private void Start()
    {   
        index = PlayerPrefs.GetInt("Character Selected");

        characterList = new GameObject[transform.childCount];

        // Fill the array with our sprite's
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }
        
        // Toggle off the renderer
        foreach (GameObject character in characterList)
        {
            character.SetActive(false);
        }

        // Toggle on the renderer for the selected Character
        if( characterList[index] ) {
            characterList[index].SetActive(true);
        }
    }

    public void ToggleSprite(string buttonName) 
    {
        // Toggle off the current sprite renderer
        characterList[index].SetActive(false);

        //Check if right or left button was pressed
        if(buttonName == "Previous Sprite") {
            index--;
            if(index < 0)
                index = characterList.Length - 1;
        } else if (buttonName == "Next Sprite") {
            index++;
            if(index == characterList.Length)
                index = 0;
        }

        // Toggle on the current sprite renderer
        characterList[index].SetActive(true);
    }

    public void ConfirmButton() 
    {
        PlayerPrefs.SetInt("Character Selected", index); // Grab the index of the sprite selected
        SceneManager.LoadScene("Test Scene");
    }
}
