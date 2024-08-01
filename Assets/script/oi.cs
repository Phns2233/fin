using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class oi : MonoBehaviour
{
    public Button[] Button;
    string myText = "dfgdgdgrdrgdrgdrgdrgdgdrgdrgdrgdgdr";
    char[] crt;
    public Text viewer;
    // Start is called before the first frame update
    void Start()
    {
        crt = myText.ToCharArray();
        StartCoroutine(ShowText());
    }

    // Update is called once per frame

    IEnumerator ShowText()
    {
        int count = 0;
        while (count < crt.Length)
        {
            yield return new WaitForSeconds(1);
            viewer.text += crt[count];
            count++;
        }

    }
public void ButtonApertado()
{
    
}
   
}
