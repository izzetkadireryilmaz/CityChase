using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerilerScripts : MonoBehaviour
{
    public int Alt�n;
    public Text Alt�nText;
    void Start()
    {
        if (PlayerPrefs.HasKey("Alt�n"))
        {
            Alt�n = PlayerPrefs.GetInt("Alt�n");
            Alt�nText.text = Alt�n.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("Alt�n", 0);
            Alt�nText.text = PlayerPrefs.GetInt("Alt�n").ToString();
        }
    }
}
