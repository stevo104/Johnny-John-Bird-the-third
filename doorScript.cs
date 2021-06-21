using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class doorScript : MonoBehaviour
{
    // Using 3 Different Variables for this section, The float for opening distance, Gameobject to open link the door & Vector 3 to store the transformation.
    public float openSpace;
    public GameObject BigDoor;
    public bool OPEN;
    private bool inRange;
    public GameObject latch;
   


    public float time
;
    private Vector3 closepos;

    void Start()
    {
        closepos = BigDoor.transform.localPosition;
    }
    private void OnTriggerEnter(Collider latch)
    {
 
       if (BigDoor != null)
        {
            inRange = true;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            DoorOpen();
        }

       if (BigDoor == null)
        {
            inRange = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            DoorClose();
        }



    }
    public void DoorOpen()
    {
        BigDoor.transform.DOLocalMoveX(closepos.x + openSpace, 1);
    }
    public void DoorClose()
    {
        BigDoor.transform.DOLocalMoveX(closepos.x - openSpace, 1);
    }
  
     }


