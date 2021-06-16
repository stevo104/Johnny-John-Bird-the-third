using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrigger : MonoBehaviour
{
    private bool withinrange;
    private doorScript Bigdoor;

    private void update()
    {
        if (withinrange && Bigdoor != null && Input.GetKeyDown(KeyCode.F))
        {
            Bigdoor.DoorOpen();
        }
    }

        private void OnTriggerEnter(Collider other)
        {
            Bigdoor = other.GetComponent<doorScript>();
            if (Bigdoor != null)
            {
                withinrange = true;
            }
        }
    private void OnTriggerExit(Collider other)
    {
        if (other.name.Contains("Door"))
        {
            withinrange = false;
            Bigdoor = null;
        }
    }
}
    
