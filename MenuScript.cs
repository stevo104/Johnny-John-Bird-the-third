using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour
{ 
    public AudioMixer mixer;

    // When Clicked this will cause the first level of the game to load straight away which is "Map Be Gone"
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // This will allow the Player to Quit application, pretty standard code there.
    public void QuitApplication()
    {
        Debug.Log("You have Quit the Game");
        Application.Quit();
    }
    // This will Load Level 1 in the Scene Hierachy which in this case is "Map Be Gone"
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    // This will Load Level 2 in the Scene Hierachy which in this case is "The Golden Eyepatch"
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
    // For the Audio slider i found a tutorial on youtube that showed me how to do it, although it is slightly different to how they set it out, Basically all it does is control the value of the volume in the mixer.
    public void SetLevel(float sliderPoint)
    {
        mixer.SetFloat("OceanFX", Mathf.Log10(sliderPoint) * 20);
    }
}


 