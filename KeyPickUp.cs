using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    public GameObject Key;
    private bool inRange;

    // Start is called before the first frame update
    void Start()
    {
        Key.SetActive(true);
    }
    void OnTriggerEnter(Collider other)
    {
        inRange = true;
        {
            if (inRange && Key != null && Input.GetKeyDown(KeyCode.F))
            {
                Destroy(Key);
            }
        }
    }
}
    
