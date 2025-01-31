using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textTimer;
    private float time;
    void Start()
    {
        time = 300;
        updateTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if(time> 0)
        {
            time -= Time.deltaTime;
            updateTimer();

        }
        else
        {
            SceneManager.LoadScene("MenuScene");
        }
    }

    public void TimerChange(int i)
    {
        time -= i * 60;
        if (time < 0) time = 0; // Prevent timer from going negative
        updateTimer();
    }

    private void updateTimer()
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
