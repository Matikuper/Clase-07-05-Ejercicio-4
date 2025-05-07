using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    public int num1;
    public int num2;
    public TMP_InputField input1;
    public TMP_InputField input2;
    public TextMeshProUGUI textoResultado;

    // Start is called before the first frame update
    void Start()
    {
        textoResultado.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sumarYMostrarResultado()
    {
        //tomar los valores del input y sumarlos
        num1 = int.Parse(input1.text);
        num2 = int.Parse(input2.text);

        textoResultado.text = $"{num1 + num2}";
    }

}
