using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
public class textFala : MonoBehaviour
{
    string myText = $"OI Fabricio queria saber se você quer ir ao cinema";
    //"presizo para sair com uma mina vc sabe q esta me devendo uma.";
    char[] crt;
    public float time = 0.1f;
    public Text viewer;
    Animator anim;
    public bool retornaNpc = false;

    // Start is called before the first frame update
    void Start()
    {
        crt = myText.ToCharArray();

        StartCoroutine(ShowText(anim));
        anim = GetComponent<Animator>();
    }
    IEnumerator ShowText(Animator celular)
    {
        int count = 0;
        while (count < crt.Length)
        {
            yield return new WaitForSeconds(time);
            viewer.text += crt[count];
            count++;
            anim.SetLayerWeight(0, 1);
        }
    }


}