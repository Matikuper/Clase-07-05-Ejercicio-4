using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Animalitos : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField InputCodigo;
    public TMP_InputField InputDias;
    string codigo;
    int cantDias;
    int comidaPerrosPeque = 400;
    int comidaPerrosGrandes = 700;
    int comidaGatos = 300;
    int comidaAnimalIndicado;
    int comidaTotal;
    int precioTotal;
    int precioPorCienGramos = 80;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = string.Empty;
    }

    public void calcularComida()
    {
        if (InputDias.text == string.Empty)
        {
            txtResultado.text = "Debe ingresar un dato";
            return;
        }

        if (InputCodigo.text == string.Empty)
        {
            txtResultado.text = "Debe ingresar un dato";
            return;
        }

        codigo = InputCodigo.text;
        cantDias = int.Parse(InputDias.text);

        if (cantDias < 3)
        {
            txtResultado.text = "La cantidad de días no puede ser menor a 3";
            return;
        }

        if (codigo != "G" && codigo != "PP" && codigo != "PG")
        {
            txtResultado.text = "Código no válido";
            return;
        }

        if (codigo == "G")
        {
            comidaAnimalIndicado = comidaGatos;
        }

        else if (codigo == "PP")
        {
            comidaAnimalIndicado = comidaPerrosPeque;
        }

        else if (codigo == "PG")
        {
            comidaAnimalIndicado = comidaPerrosGrandes;
        }

        else
        {
            txtResultado.text = "Código no válido";
            return;
        }

        comidaTotal = comidaAnimalIndicado * cantDias;
        precioTotal = (comidaTotal / 100) * precioPorCienGramos;
        txtResultado.text = $"Para ese período se necesitan {comidaTotal} gramos de alimento, que saldrán {precioTotal} pesos";
    }
}
