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
            botoesResposta[i].onClick.AddListener(() => SelecionarResposta( index));
            sprite = GetComponent<Sprite>();
            anim = GetComponent<Animator>();
        }


    }

    // Método para lidar com a seleção de resposta
    void SelecionarResposta(   int index  )
    {
        if (respostaboa == true)
        {
            textoResposta.text = $"dfgdgdfgdgfdgdgdgdgd";
            anim.SetLayerWeight(1,1);
            botoesResposta[0].interactable = false;
        }
      /* if (respostaboa == false)
        {
            
            anim.SetLayerWeight(0,1);
            textoResposta.text = "ta vou sair umas 8";
            botoesResposta[0].interactable = false;
        }*/
    }

    
}