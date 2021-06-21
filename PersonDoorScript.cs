using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonDoorScript : MonoBehaviour
{ 
    private bool inRange;
    private doorScript BigDoor;

    private void Update()
    {
        if(inRange && BigDoor != null && Input.GetKeyDown(KeyCode.F))
        {
            BigDoor.DoorOpen();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        BigDoor = other.GetComponent<doorScript>();
        if (BigDoor != null)
        {
            inRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.name.Contains("BigDoor"))
        {
            inRange = false;
            BigDoor = null;
        }
    }
    
    
}


