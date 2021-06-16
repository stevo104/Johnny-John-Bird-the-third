using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour

    public AudioMixer mixer;

{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitApplication()
    {
        Debug.Log("You have Quit the Game");
        Application.Quit();
    }
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }

    public void SetLevel(float sliderPoint)
    {
        mixer.SetFloat("OceanFX", Mathf.Log10(sliderValue) * 20);
    }
}
