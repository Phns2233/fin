using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textFala : MonoBehaviour
{
    string myText =$"OI Fabricio queria saber se você quer ir ao cinema comigo e o povo ?\nse você quiser lava uns 70R$ flw.";
    //"presizo para sair com uma mina vc sabe q esta me devendo uma.";
    char[] crt;
    public float time = 0.1f;
    public Text viewer;
   
    // Start is called before the first frame update
    void Start()
    {
        crt = myText.ToCharArray();

        StartCoroutine(ShowText());
    }
 IEnumerator ShowText()
   {
    int count = 0;
    while(count < crt.Length) 
    {
        yield return new WaitForSeconds(time);
        viewer.text += crt[count];
        count++;
    }
   }


}