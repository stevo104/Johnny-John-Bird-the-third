using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Universaldoorscript : MonoBehaviour
{
    //The Different Varaiables within the Script, only 3 of them can be edited in Unity, the rest are permanent.
    public float openSpace;
    public float time;
    public GameObject Switch;
    public GameObject bigDoor;
    public GameObject uiObject;
    private Vector3 closepos;
  
 // at the start, the script will have the UI pop up set to "off" and the "Big door" will be closed.
    void Start()
    {
        uiObject.SetActive(false);
        closepos = bigDoor.transform.localPosition;
    }
    public void DoorOpen()
 // This is the function that causes the door to move along the "X Axis", will only happen when called upon however. 
    {
        bigDoor.transform.DOLocalMoveX(closepos.x + openSpace, 1);
    }
    void OnTriggerEnter(Collider player)
 // When the player enters the trigger it will check for the tag, if successful it will display the UI Object on Screen and trigger the countdown to begin.
    {
        if (player.gameObject.tag == "Johnny")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitSec");
        }
    }
    private IEnumerator WaitSec()
 // When the countdown reaches zero the UI text will dissapear from the screen, until the collider is walked into again.
    {
        yield return new WaitForSeconds(2);
        uiObject.SetActive(false);
    }
}

