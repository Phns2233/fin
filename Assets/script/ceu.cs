using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ceu : MonoBehaviour
{
    // Referências aos botões
    public Button[] botoesResposta;
    // Referência ao texto que mostrará a resposta selecionada
    public Text textoResposta;
    public Animator anim;
    public Sprite sprite;
    public bool respostaboa = false;
    public bool contarTempo = false;
    public float time = 30f;

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
    void SelecionarResposta(Animator celular, int index)
    {
        // Exibe a resposta selecionada no texto
        if (respostaboa == false)
        {
            anim.SetLayerWeight(1, 1);
            textoResposta.text = "ta bom ";
            botoesResposta[0].interactable = false;
            new WaitForSecondsRealtime(time);
            SceneManager.LoadScene("cena1");
        }

        if (respostaboa == false)
        {

        }
    }


    public void contarTempoDoJogo()
    {

    }
}