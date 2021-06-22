﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playsound : MonoBehaviour
{
    public AudioClip SoundToPlay;
    AudioSource soundSource;

    // Start is called before the first frame update
    void Start()
    {
        soundSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.F))
        soundSource.PlayOneShot(SoundToPlay);
    }
}