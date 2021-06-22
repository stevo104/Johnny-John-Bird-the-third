using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiSwitch : MonoBehaviour
{

    public GameObject uiObject;

    void Start()
     // Set the UI Text Object to false so it does not show up on screen
    {
        uiObject.SetActive(false);
    }
   
    void OnTriggerEnter(Collider player)
        // When the player enters the trigger it will check for the tag, if successful it will display the UI Object on Screen
    {
        if (player.gameObject.tag == "Johnny")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitSec");
        }
    }

    private IEnumerator WaitSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
        Destroy(gameObject);

    }
}