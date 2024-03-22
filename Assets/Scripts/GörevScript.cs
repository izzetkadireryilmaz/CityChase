using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GörevScript : MonoBehaviour
{
    public GameObject TarsusGörevAlma;
    public GameObject MersinGörevAlma;
    public GameObject TarsusGörev;
    public GameObject MersinGörev;
    public GameObject GörevTeslim;
    public GameObject MersinGörevYeri;
    public GameObject TarsusGörevYeri;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TarsusGörevYeri")
        {
            if (MersinGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
            else
            {
                TarsusGörevAlma.SetActive(true);
            }
        }
        if (other.gameObject.tag == "MersinGörevYeri")
        {
            if (TarsusGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
            else
            {
                MersinGörevAlma.SetActive(true);
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "TarsusGörevYeri")
        {
            TarsusGörevAlma.SetActive(false);
            GörevTeslim.SetActive(false);
        }
        if (other.gameObject.tag == "MersinGörevYeri")
        {
            MersinGörevAlma.SetActive(false);
            GörevTeslim.SetActive(false);
        }
    }
}
