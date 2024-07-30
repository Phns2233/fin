using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuResposta : MonoBehaviour
{
    // Referências aos botões
    public Button[] botoesResposta;
    // Referência ao texto que mostrará a resposta selecionada
    public Text textoResposta;
    public Animator anim;
    public Sprite sprite;
    public bool respostaboa = false;

    // Método para inicializar o script
    void Start()
    {
        // Adiciona um listener para cada botão
        for (int i = 0; i < botoesResposta.Length; i++)
        {
            int index = i; // Armazena o índice do botão para usar no listener
            botoesResposta[i].onClick.AddListener(() => SelecionarResposta(anim, index));
            sprite = GetComponent<Sprite>();
            anim = GetComponent<Animator>();
        }


    }

    // Método para lidar com a seleção de resposta
    void SelecionarResposta( Animator dinheiro , int index )
    {
        if (respostaboa == true)
        {
            textoResposta.text = $"Esta bem mais eu presizo do dinheiro na proxima semana.";
            anim.SetLayerWeight(1,1);
        }
    }

    /*public void animResposta()
    {
       if(respostaboa== false)
        {
            anim.SetLayerWeight(0,1);
        }

        else if(respostaboa == true)
        {
            anim.SetLayerWeight(1,1);
        } 
    }*/
}