using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public int num1;
    public int num2;
    public TMP_InputField InputNum1;
    public TMP_InputField InputNum2;
    public TextMeshProUGUI textResultado;

    // Start is called before the first frame update
    void Start()
    {
        textResultado.text = "";
    }

    public void sumarYMostrarResultado()
    {
        num1 = int.Parse(InputNum1.text);
        num2 = int.Parse(InputNum2.text);

        // textResultado.text = 

        textResultado.text = $"{num1 + num2 }";

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
