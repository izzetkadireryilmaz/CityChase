using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerilerScripts : MonoBehaviour
{
    public int Altýn;
    public Text AltýnText;
    void Start()
    {
        if (PlayerPrefs.HasKey("Altýn"))
        {
            Altýn = PlayerPrefs.GetInt("Altýn");
            AltýnText.text = Altýn.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("Altýn", 0);
            AltýnText.text = PlayerPrefs.GetInt("Altýn").ToString();
        }
    }
}
