using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripts : MonoBehaviour
{
    public GameObject G�rev;
    public GameObject G�revTeslimButton;
    public GameObject TarsusG�rev;
    public GameObject MersinG�rev;
    public void G�revButton()
    {
        if (G�rev.gameObject.tag == "TarsusG�rev")
        {
            TarsusG�rev.SetActive(true);
        }
        if (G�rev.gameObject.tag == "MersinG�rev")
        {
            MersinG�rev.SetActive(true);
        }
    }
    public void G�revTeslim()
    {
        if (MersinG�rev.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            MersinG�rev.SetActive(false);
            
            
        }
        else if(TarsusG�rev.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            TarsusG�rev.SetActive(false);
            
        }
    }
}
