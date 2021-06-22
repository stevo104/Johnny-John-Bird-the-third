using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class doorScript : MonoBehaviour
{
    // Using 3 Different Variables for this section, The float for opening distance, Gameobject to open link the door & Vector 3 to store the transformation.
    public float openSpace;
    public float time;
    public GameObject Switch;
    public GameObject bigDoor;
  

    
    private Vector3 closepos;
    void Start()
    {
        { 
        closepos = bigDoor.transform.localPosition;
        }
    }
    private void Update()
    { 
    //if (Input.GetKeyDown(KeyCode.F))
    //    {
    //   DoorClose();
    //    }
    }
    public void DoorOpen()
    {
        bigDoor.transform.DOLocalMoveX(closepos.x + openSpace, 1);
    }
 
    public void DoorClose()
    {
        bigDoor.transform.DOLocalMoveX(closepos.x, 1);
    }
  
     }


