using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Questions : MonoBehaviour
{
    public List<string> question = new List<string>();
    public List<string> answer = new List<string>();
    public List<string> hint = new List<string>();

    public TextMeshProUGUI qText, clue;
    public TMP_InputField inputField;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(question.Count);
        qText.text = question[index];
    }

    // Update is called once per fram

    
    public void CheckAnswer()
    {
        string input = inputField.text;

        if (input.ToLower() == answer[index].ToLower())
        {
            clue.text += "\n" + hint[index];

        }
        index++;
        if (index < question.Count)
        {
            qText.text = question[index];
            inputField.text = "";
          
        }
        else
        {
            qText.text = "NO MORE QUESTION\nGOOD LUCK";
            inputField.DeactivateInputField();
            
        }
       
    }

   
}
