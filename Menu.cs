using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Scene-3");
    }
    //to pause time.timescale=0
    //to resume time.timescale=1
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene("Scene-3");
    }
    public void updatenext()
    {
        SceneManager.LoadScene("Scene-2");
    }
    public void Quit()
    {
        Application.Quit();
        //Debug.log("quit");
    }

}
//https://developer.vuforia.com/
