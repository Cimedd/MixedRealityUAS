using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class KeyCheck : MonoBehaviour
{
    private XRSocketInteractor socket;
    public GameObject timerObj;
    private Timer timerScript;
    public TextMeshProUGUI screen;
    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
        timerScript = timerObj.GetComponent<Timer>();
    }


    public void checkSocket()
    {
        GameObject item = socket.selectTarget.gameObject;
        if (item.name == "Key1")
        {
            Debug.Log("Correct");
            SceneManager.LoadScene("Library");
            
        }
        else
        {
            timerScript.TimerChange(1);
        }

    }
}
