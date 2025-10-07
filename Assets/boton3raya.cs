using UnityEngine;
using TMPro;

public class boton3raya : MonoBehaviour
{

    public int indice = 0;
    public TextMeshProUGUI textMeshPro;
    public TextMeshProUGUI textMeshProIndice;


    private void Start()
    {
        textMeshProIndice.text = indice.ToString();
        textMeshPro.text = "";
    }

}
