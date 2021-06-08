using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorSwitch : MonoBehaviour
  
{
    public GameObject bigDoor;
    public GameObject openDoorText;
    public AnimationClip doorOpen;
    public AnimationClip doorClose;


    // Start is called before the first frame update
    void Start()
    {// Activating the door open, 
        if
           (Input.GetKeyDown(KeyCode.F))
        {
            bigDoor.SetActive(!bigDoor.activeSelf);
            doorOpen = GameObject.Find = (bigDoor);
            
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        openDoorText.SetActive(true);
        openDoorText.GetComponent<Text>().text = "Press F to open the door";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
    