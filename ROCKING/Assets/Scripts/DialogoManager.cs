using UnityEngine;
using TMPro;
using System.Collections;

public class DialogoManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textMeshPro; // Texto da fala
    [SerializeField] TextMeshProUGUI _continueText; // Texto "Pressione espaço p continuar..."

    public string[] stringArray;


    [SerializeField] float tempoEntreLetra;

    int i = 0; // Iterador da lista de caracteres
    bool podeAvancar = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _continueText.gameObject.SetActive(false);
        MostrarFala();
    }

    void Update()
    {
        if (podeAvancar && Input.GetKeyDown(KeyCode.Space))
        {
            podeAvancar = false;
            _continueText.gameObject.SetActive(false);
            MostrarFala();
        }
    }


    void MostrarFala()
    {
        if (i < stringArray.Length)
        {
            _textMeshPro.text = stringArray[i];
            _textMeshPro.maxVisibleCharacters = 0;
            StartCoroutine(TextVisible());
        }
        else
        {
            // quando acaba o diálogo
            _textMeshPro.text = "";
            _continueText.gameObject.SetActive(false);
        }
    }

    private IEnumerator TextVisible()
    {
        _textMeshPro.ForceMeshUpdate();
        int totalVisibleCharacters = _textMeshPro.textInfo.characterCount;
        int counter = 0;

        while (counter <= totalVisibleCharacters)
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);
            _textMeshPro.maxVisibleCharacters = visibleCount;

            counter += 1;
            yield return new WaitForSeconds(tempoEntreLetra);
        }

        // quando acaba de mostrar tudo, libera pra passar pro próximo:
        _continueText.gameObject.SetActive(true);
        podeAvancar = true;
        i += 1;
    }
}
