using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneChecker : MonoBehaviour
{
    public TextMeshProUGUI display, batteryDisplay;
    private int battery = 20;
    // Start is called before the first frame update
    void Start()
    {
        batteryDisplay.text = $"{battery}%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressNumber(int i)
    {
        display.text += i.ToString();
    }

    public void RemoveNumber()
    {
        if (display.text.Length > 0)
        {
            display.text = display.text.Substring(0, display.text.Length - 1);
        }
    }

    public void Call()
    {
        if(battery > 0)
        {
            if (display.text == "08359007184")
            {
                Debug.Log("Correct");
                SceneManager.LoadScene("Labyrinth");
            }
            else
            {
                battery -= 5;
                batteryDisplay.text = $"{battery}%";

                display.text = "";
            }
        }
        else
        {
            SceneManager.LoadScene("MenuScene");
        }
        
    }

}
