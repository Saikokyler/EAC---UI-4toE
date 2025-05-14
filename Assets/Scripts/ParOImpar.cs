using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParOImpar : MonoBehaviour
{
    int num1; 
    public TMP_InputField InputNumero;
    public TextMeshProUGUI textresultado;

    // Start is called before the first frame update
    void Start()
    {
      // textResultado.text= string.Empty;

        textresultado.text = "";
    }

    public void EsParONo()
    {
        if (InputNumero.text == "")
        {
            textresultado.text = "Complete el campo solicitado";
            return;
        }

        num1 = int.Parse(InputNumero.text);

        if (num1 <= 0)
        {
            textresultado.text = "El número debe ser mayor que cero";
            return;
        }

        if (num1 % 2 == 0)
        {
            textresultado.text = "El número es par"; 
        }
        else
        {
            textresultado.text = "El número es impar";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
