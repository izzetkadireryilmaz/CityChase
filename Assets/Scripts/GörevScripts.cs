using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GörevScripts : MonoBehaviour
{
    public GameObject Görev;
    public GameObject GörevTeslim;
    public GameObject MersinGörev;
    public GameObject TarsusGörev;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TarsusGörev")
        {
            if (MersinGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
            else
            {
                Görev.SetActive(true);
            }
        }
        if (other.gameObject.tag == "MersinGörev")
        {
            if (TarsusGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
            else
            {
                Görev.SetActive(true);
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "TarsusGörev")
        {
            Görev.SetActive(false);
            GörevTeslim.SetActive(false);
        }
        if (other.gameObject.tag == "MersinGörev")
        {
            Görev.SetActive(false);
            GörevTeslim.SetActive(false);
        }
    }
}
