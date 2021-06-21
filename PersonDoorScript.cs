using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonDoorScript : MonoBehaviour
{
    private bool inRange;
    private doorScript bigDoor;

    private void Update()
    {
        if (inRange && bigDoor != null && Input.GetKeyDown(KeyCode.F))
        {
            bigDoor.DoorOpen();
        }

        if (inRange && bigDoor == null && Input.GetKeyDown(KeyCode.F))
        {
            bigDoor.DoorClose();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        bigDoor = other.GetComponent<doorScript>();
        if (bigDoor != null)
        {
            inRange = true; if (inRange && bigDoor != null && Input.GetKeyDown(KeyCode.F))
            {
                bigDoor.DoorOpen();
            }
        }

        private void OnTriggerExit(Collider col)

        if (bigDoor == null)
        {
            if (Input.GetKeyDown(KeyCode.F))

            {
                bigDoor.DoorClose();
            }
        }
        }

    }


    





