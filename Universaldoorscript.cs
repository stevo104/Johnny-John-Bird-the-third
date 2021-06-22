using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Universaldoorscript : MonoBehaviour
{
    public float openSpace;
    public float time;
    public GameObject Switch;
    public GameObject bigDoor;
    public GameObject uiObject;
    private Vector3 closepos;
    

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        closepos = bigDoor.transform.localPosition;
    }
 
    public void DoorOpen()
    {
        bigDoor.transform.DOLocalMoveX(closepos.x + openSpace, 1);
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
        yield return new WaitForSeconds(2);
        uiObject.SetActive(false);

    }
        }

