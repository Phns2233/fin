using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string sceneToLoad; // Nome da cena para carregar quando o jogador entra na porta

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CarroVermelho")) // Verifica se o objeto que colidiu Ã© o jogador
        {
            this.CompareTag("CarroVermelho");
            Destroy(other.gameObject);
            SceneManager.LoadScene("menu"); // Carrega a cena especificada
        }
    }
}