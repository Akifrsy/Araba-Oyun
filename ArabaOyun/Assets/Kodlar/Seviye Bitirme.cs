using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeviyeBitirme : MonoBehaviour
{
    public void seviye1bitir()
    {
        Yonetici.seviye2 = true;
        SceneManager.LoadScene(3);
    }
    
    public void seviye2bitir()
    {
        Yonetici.seviye3 = true;
        SceneManager.LoadScene(4);
    }

    public void seviye3bitir()
    {
        Yonetici.seviye4 = true;
        SceneManager.LoadScene(5);
    }

    public void seviye4bitir()
    {
        Yonetici.seviye5 = true;
        SceneManager.LoadScene(6);
    }

    public void seviye5bitir()
    {
        SceneManager.LoadScene(1);
    }
}


