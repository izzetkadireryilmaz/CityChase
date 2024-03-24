using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject TarsusGörev;
    public GameObject MersinGörev;
    public GameObject OtelGörev;
    public GameObject MarketGörev;
    public GameObject KarakolGörev;
    public GameObject ArabaGörev;
    public GameObject TamirGörev;
    public GameObject BankaGörev;
    public GameObject ÝþMerkeziGörev;
    public GameObject GörevTeslimButton;
    public GameObject TarsusGörevAçýklama;
    public GameObject MersinGörevAçýklama;
    public GameObject OtelGörevAçýklama;
    public GameObject MarketGörevAçýklama;
    public GameObject KarakolGörevAçýklama;
    public GameObject ArabaGörevAçýklama;
    public GameObject TamirGörevAçýklama;
    public GameObject BankaGörevAçýklama;
    public GameObject ÝþMerkeziGörevAçýklama;

    public void TarsusGörevButton()
    {
        TarsusGörevAçýklama.SetActive(true);
    }
    public void MersinGörevButton()
    {
        MersinGörevAçýklama.SetActive(true);
    }
    public void OtelGörevButton()
    {
        OtelGörevAçýklama.SetActive(true);
    }
    public void MarketGörevButton()
    {
        MarketGörevAçýklama.SetActive(true);
    }
    public void KarakolGörevButton()
    {
        KarakolGörevAçýklama.SetActive(true);
    }
    public void ArabaGörevButton()
    {
        ArabaGörevAçýklama.SetActive(true);
    }
    public void TamirGörevButton()
    {
        TamirGörevAçýklama.SetActive(true);
    }
    public void BankaGörevButton()
    {
        BankaGörevAçýklama.SetActive(true);
    }
    public void ÝþMerkeziGörevButton()
    {
        ÝþMerkeziGörevAçýklama.SetActive(true);
    }


    public void GörevTeslim()
    {
        if (MersinGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            MersinGörevAçýklama.SetActive(false);
        }

        else if (TarsusGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            TarsusGörevAçýklama.SetActive(false);
        }
        else if (OtelGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            OtelGörevAçýklama.SetActive(false);
        }
        else if (MarketGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            MarketGörevAçýklama.SetActive(false);
        }
        else if (KarakolGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            KarakolGörevAçýklama.SetActive(false);
        }
        else if (ArabaGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            ArabaGörevAçýklama.SetActive(false);
        }
        else if (TamirGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            TamirGörevAçýklama.SetActive(false);
        }
        else if (BankaGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            BankaGörevAçýklama.SetActive(false);
        }
        else if (ÝþMerkeziGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            ÝþMerkeziGörevAçýklama.SetActive(false);
        }
    }
}
