using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bolum : MonoBehaviour
{
    void OnTriggerEnter(Collider nesne)
    {
        if (nesne.tag == "nextlevel")
        {
            SceneManager.LoadScene(3);
        }
    }
}
