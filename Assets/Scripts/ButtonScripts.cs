using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripts : MonoBehaviour
{
    public GameObject Görev;
    public GameObject GörevTeslimButton;
    public GameObject TarsusGörev;
    public GameObject MersinGörev;
    public void GörevButton()
    {
        if (Görev.gameObject.tag == "TarsusGörev")
        {
            TarsusGörev.SetActive(true);
        }
        if (Görev.gameObject.tag == "MersinGörev")
        {
            MersinGörev.SetActive(true);
        }
    }
    public void GörevTeslim()
    {
        if (MersinGörev.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            MersinGörev.SetActive(false);
            
            
        }
        else if(TarsusGörev.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            TarsusGörev.SetActive(false);
            
        }
    }
}
