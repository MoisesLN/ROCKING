using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("JogoPrincipal");
    }

    public void IrConfiguracoes()
    {
        SceneManager.LoadScene("Configuracoes");
    }

    public void Quitar()
    {
        Application.Quit();
    }
}
