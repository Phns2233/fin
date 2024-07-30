using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creditos : MonoBehaviour
{
    string myText = " Jogo criado por: Pedro.H.neris , Carol , Kevin. \n Programador: Pedro.H.neris e Kevin. \n Artes: Pedro.H.neris e Kevin. ";//texto a ser escrito
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
            time = 2;
            yield return new WaitForSeconds(time);
            viewer.text += crt[count];
            count++;

        }
    }


}