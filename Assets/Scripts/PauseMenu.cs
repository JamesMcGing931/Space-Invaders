using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    private bool isPaused;
    public GameObject pausePanel;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause")) 
        {
            if (isPaused)
            {
                TimeResume();
            }
            else
            {
                TimePause();
            }
        }
    }

    public void TimePause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        isPaused = true;
    }

    public void TimeResume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        isPaused = false;
    }
}
