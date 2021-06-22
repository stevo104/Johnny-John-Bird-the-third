using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonDoorScript : MonoBehaviour
{
    private bool inRange;
    private Universaldoorscript bigDoor;

    private void Update()
    {
        if (inRange && bigDoor != null && Input.GetKeyDown(KeyCode.F))
        {
            bigDoor.DoorOpen();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        bigDoor = other.GetComponent<Universaldoorscript>();
        if (bigDoor != null)
        {
            inRange = true; if (inRange && bigDoor != null && Input.GetKeyDown(KeyCode.F))
            {
                bigDoor.DoorOpen();
            }
        }
    }
}
    


    





