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
    private void Update()
    {
        if (inRange && BigDoor != null & Input.GetKeyDown(KeyCode.F))
        {
            DoorOpen();
        }
        if (inRange && BigDoor == null & Input.GetKeyDown(KeyCode.F))
        {
            DoorClose();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if (BigDoor != null)
        {
            inRange = true;
        }
       if (BigDoor == null)
        {
            inRange = false;
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


