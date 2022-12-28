using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sayac : MonoBehaviour
{
    public float dakika, saniye;
    public Text suretext;
    public Text oyunsonu;
    public GameObject tekrardeneButton;

    void Start()
    {
        dakika = 00;
        saniye = 11;
    }

    void Update()
    {
        saniye -= Time.deltaTime;
        suretext.text = "" + dakika + ":" + (int)saniye;
        

        if (saniye <= 0)
        {
            saniye = 0;
            
        }

        if(saniye<1)
        {
            Time.timeScale = 1;
            oyunsonu.gameObject.SetActive(true);
            tekrardeneButton.SetActive(true);
            oyunsonu.text = "Süre Doldu";
        }
         

    }

    public void TekrarDene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
        
    }

   

}
    