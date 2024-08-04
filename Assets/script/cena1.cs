using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cena1 : MonoBehaviour
{
    string myText = " tomara que não tenha chegado atrasado ";//texto a ser escrito
    char[] crt; //caracter
    public float time = 0.05f;
    public Text viewer;
    // Start is called before the first frame update
    void Start()
    {
        crt = myText.ToCharArray();

        StartCoroutine(ShowText());
    }

    IEnumerator ShowText() //variavel para escrever o texto vou dar um commit depois 
    {
        int count = 0;
        while (count < crt.Length)
        {
            
            yield return new WaitForSeconds(time);
            viewer.text += crt[count];
            count++;

        }
    }
}