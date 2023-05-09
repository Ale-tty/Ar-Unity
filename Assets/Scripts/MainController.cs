using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class MainController : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI capturados;

    private void Update()
    {
        capturados.text = AudioController.txt;
    }

}
