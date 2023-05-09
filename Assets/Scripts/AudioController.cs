using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSrc;
   // public bool isPlaying;
    public Animator anim;

    public TextMeshProUGUI dinoName;
    public TextMeshProUGUI dinoInfo;

    private string dinoActual = "";

    public static string txt = $"Captura a los 5 dinosaurios para ganar ";

    public static Dictionary<string, bool> dinosaurs = new Dictionary<string, bool>()
    {
        { "Velociraptor", false },
        { "Paquicefalosaurio", false },
        { "Tiranosaurio rex", false },
        { "Triceratops", false },
        { "Brontosaurio", false },
    };


    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        // isPlaying = false;
    }

    private void Update()
    {
        if (!string.IsNullOrEmpty(dinoName.text))
        {
            if (!dinosaurs[dinoName.text])
            {
                dinoInfo.text = "Presiona el triangulo para capturar este dinosaurio";
            }
            else
            {
                dinoInfo.text = "¡Capturado!";
            }
        }
    }

    public void PlayDescription()
    {
        audioSrc.Play();
       // isPlaying = true;
        anim.SetBool("isPlaying", true);
        dinoActual = dinoName.text;
        print(dinoActual);
        
        if (!dinosaurs[dinoActual])
        {
            dinosaurs[dinoActual] = true;
        }

        GetCapturedDinos();
    }

    public void PauseDescription()
    {
        audioSrc.Pause();
       // isPlaying = false;
        anim.SetBool("isPlaying", false);

    }


    public void StopDescription()
    {
        audioSrc.Stop();
       // isPlaying = false;
        anim.SetBool("isPlaying", false);

    }

    public void GetCapturedDinos()
    {
        
        int totalDinos = dinosaurs.Count;
        int totalCaptured = dinosaurs.Count(kv => kv.Value == true);

        if (totalDinos == totalCaptured)
        {
            txt = $"¡Ganaste, has capturado a los {totalDinos} dinosaurios!";
        } else
        {
            txt = $"{totalCaptured} de {totalDinos} dinosaurios capturados";
        }

        print(txt);

    }
}
