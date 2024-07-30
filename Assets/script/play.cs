using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("fase1");
    }

    public void CreditosGame()
    {
        SceneManager.LoadScene("creditos");
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene("menu");
    }

}