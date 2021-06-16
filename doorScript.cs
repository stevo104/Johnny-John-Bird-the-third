using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class doorScript : MonoBehaviour
{
    // Using 3 Different Variables for this section, The float for opening distance, Gameobject to open link the door & Vector 3 to store the transformation.
    public float openSpace;
    public GameObject BigDoor;

    private Vector3 closepos;

    void Start()
    {
        closepos = BigDoor.transform.localPosition;
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

