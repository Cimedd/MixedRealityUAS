using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{
    // Start is called before the first frame update
    public Light pointLight;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void ToggleLight()
    {
        if (pointLight != null)
        {
            pointLight.enabled = !pointLight.enabled;
            Debug.Log("Spotlight");
        }
    }
}
