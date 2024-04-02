using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GörevScript : MonoBehaviour
{
    public GameObject TarsusGörevAlma;
    public GameObject MersinGörevAlma;
    public GameObject OtelGörevAlma;
    public GameObject MarketGörevAlma;
    public GameObject KarakolGörevAlma;
    public GameObject ArabaGörevAlma;
    public GameObject TamirGörevAlma;
    public GameObject BankaGörevAlma;
    public GameObject İşMerkeziGörevAlma;
    public GameObject TarsusGörev;
    public GameObject MersinGörev;
    public GameObject OtelGörev;
    public GameObject MarketGörev;
    public GameObject KarakolGörev;
    public GameObject ArabaGörev;
    public GameObject TamirGörev;
    public GameObject BankaGörev;
    public GameObject İşMerkeziGörev;
    public GameObject GörevTeslim;
    public GameObject MersinGörevYeri;
    public GameObject TarsusGörevYeri;
    public GameObject OtelGörevYeri;
    public GameObject MarketGörevYeri;
    public GameObject KarakolGörevYeri;
    public GameObject ArabaGörevYeri;
    public GameObject TamirGörevYeri;
    public GameObject BankaGörevYeri;
    public GameObject İşMerkeziGörevYeri;
    public GameObject TarsusİşMerkeziGörevYeri;
    public GameObject YarışKabul;
    public GameObject YarışCollider;


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
        if (other.gameObject.tag == "OtelGörevYeri")
        {
            if (KarakolGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
            else
            {
                OtelGörevAlma.SetActive(true);
            }
        }
        if (other.gameObject.tag == "MarketGörevYeri")
        {
            if (OtelGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
            else
            {
                MarketGörevAlma.SetActive(true);
            }
        }
        if (other.gameObject.tag == "KarakolGörevYeri")
        {
            if (MarketGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
            else
            {
                KarakolGörevAlma.SetActive(true);
            }
        }
        if (other.gameObject.tag == "ArabaGörevYeri")
        {
            if (TamirGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
            else
            {
                ArabaGörevAlma.SetActive(true);
            }
        }
        if (other.gameObject.tag == "TamirGörevYeri")
        {
            if (ArabaGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
            else
            {
                TamirGörevAlma.SetActive(true);
            }

        }
        if (other.gameObject.tag == "BankaGörevYeri")
        {
            BankaGörevAlma.SetActive(true);
        }
        if (other.gameObject.tag == "İşMerkeziGörevYeri")
        {
            if (BankaGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
            else
            {
                İşMerkeziGörevAlma.SetActive(true);
            }

        }
        if (other.gameObject.tag == "TarsusİşMerkeziGörevYeri")
        {
            if (İşMerkeziGörev.activeSelf)
            {
                GörevTeslim.SetActive(true);
            }
        }
        if (other.gameObject.tag == "YarışKabulYeri")
        {
            YarışKabul.SetActive(true);
        }
        if (other.gameObject.tag == "PistAşağısı")
        {
            YarışCollider.SetActive(false);
            transform.position = new Vector3(255,0,60);
            transform.rotation = new Quaternion(0,0,0,0);
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
        if (other.gameObject.tag == "OtelGörevYeri")
        {
            OtelGörevAlma.SetActive(false);
            GörevTeslim.SetActive(false);
        }
        if (other.gameObject.tag == "MarketGörevYeri")
        {
            MarketGörevAlma.SetActive(false);
            GörevTeslim.SetActive(false);
        }
        if (other.gameObject.tag == "KarakolGörevYeri")
        {   KarakolGörevAlma.SetActive(false);
            GörevTeslim.SetActive(false);
        }
        if (other.gameObject.tag == "ArabaGörevYeri")
        {
            ArabaGörevAlma.SetActive(false);
            GörevTeslim.SetActive(false);
        }
        if (other.gameObject.tag == "TamirGörevYeri")
        {
            TamirGörevAlma.SetActive(false);
            GörevTeslim.SetActive(false);
        }
        if (other.gameObject.tag == "BankaGörevYeri")
        {
            BankaGörevAlma.SetActive(false);
        }
        if (other.gameObject.tag == "İşMerkeziGörevYeri")
        {
            İşMerkeziGörevAlma.SetActive(false);
            GörevTeslim.SetActive(false);
        }
        if (other.gameObject.tag == "TarsusİşMerkeziGörevYeri")
        {
            GörevTeslim.SetActive(false);
        }
        if(other.gameObject.tag == "YarışKabulYeri")
        {
            YarışKabul.SetActive(false);
        }

    }
}
