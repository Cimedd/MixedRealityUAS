using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Book : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int index;
    public List<string> isi = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        text.text = isi[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateIndex(int i)
    {
        index += i;
        if (index < isi.Count && index >= 0)
        {
            text.text = isi[index];
        }
    }
}
