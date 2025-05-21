using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ComidaDeAnimalitosUI : MonoBehaviour
{

    public TextMeshProUGUI txtResultado;
    public TMP_InputField InputCodigo;
    public TMP_InputField inputCanDias;
    string codigo;
    int cantDias;
    int comidaPerrosPeq = 400;
    int comidasPerrosGrandes = 700;
    int comidaGatos = 300;
    int comidaAnimalIndicado;
    int cantComidaTotal;
    float precioPorCienGramos = 80;
    float precioTotal;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = string.Empty;
    }

    public void CalcularComida()
    {
        if (inputCanDias.text == string.Empty)
        {
            txtResultado.text = "Debe ingresar una cantidad de días";
            return;
        }
        if (InputCodigo.text == string.Empty)
        {
            txtResultado.text = "Debe ingresar un código";
            return;
        }

        codigo = InputCodigo.text;
        cantDias = int.Parse(inputCanDias.text);

        if (cantDias < 3)
        {
            txtResultado.text = "La cantidad de días no puede ser menor que 3";
            return;
        }

        if (codigo != "G" && codigo != "pp" && codigo != "PG")
        {
            txtResultado.text = "Código no valido";
            return;
        }

        else if (codigo == "G")
        {
            comidaAnimalIndicado = comidaGatos;
        }

        else if (codigo == "PG")
        {
            comidaAnimalIndicado = comidasPerrosGrandes;

        }

        else
        {
            txtResultado.text = "Código no válido";
            return;
        }

        cantComidaTotal = comidaAnimalIndicado * cantDias;
        precioTotal = (cantComidaTotal / 100) * precioPorCienGramos;
        txtResultado.text ="$Para ese pre begwrgrgw"

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
