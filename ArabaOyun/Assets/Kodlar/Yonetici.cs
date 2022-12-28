using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yönteci : MonoBehaviour
{
    public Button seviye_button, seviye1_button2, seviye3_button, seviye4_button, seviye5_button;

    public static bool seviye1, seviye2, seviye3, seviye4, seviye5;

    private void start()
    {
        seviye1 = true;
    }
    private void Update()
    {
        if (seviye2 == true)
        {
            seviye2_button.interactable = true;
        }

        if (seviye3 == true)
        {
            seviye3_button.interactable = true;
        }

        if (seviye4 == true)
        {
            seviye4_button.interactable = true;
        }

        if (seviye5 == true)
        {
            seviye5_button.interactable = true;
        }

    }



}
