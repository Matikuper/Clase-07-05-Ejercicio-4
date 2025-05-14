using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class actividad6 : MonoBehaviour
{
    public TMP_InputField Input;
    public TextMeshProUGUI Respuesta;
    int num1;

    // Start is called before the first frame update
    void Start()
    {
        Respuesta.text = string.Empty;
    }

    public void ParImpar()
    {
        num1 = int.Parse(Respuesta.text);
        if (num1 <= 0)
        {
            Respuesta.text = "El número no puede ser cero ni negativo";
            return;
        }

        if (num1 % 2 == 0)
        {
            Respuesta.text = "El número es par";
        }

        else
        {
            Respuesta.text = "El número es impar";
        }
    }
}
