using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ButtonScript : MonoBehaviour
{
    public int Altýn;
    public Text AltýnText;
    public int Þöhret;
    public Text ÞöhretText;
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
    public GameObject YarýþKabul;
    public GameObject yetersiz;
    public GameObject Yarýþcollider;


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

        if (PlayerPrefs.HasKey("Þöhret"))
        {
            Þöhret = PlayerPrefs.GetInt("Þöhret");
            ÞöhretText.text = Þöhret.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("Þöhret", 0);
            ÞöhretText.text = PlayerPrefs.GetInt("Þöhret").ToString();
        }
    }
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
    public void YarýþKabulButton()
    {
        if(Altýn >= 5 && Þöhret >= 1)
        {
            Player.transform.position = new Vector3(123, 2.8f, 526);
            Yarýþcollider.SetActive(true);

        }
        else
        {
            yetersiz.SetActive(true);
            YarýþKabul.SetActive(false);
        }
    }
    public void YetersizKapat()
    {

        yetersiz.SetActive(false);
    }


    public void GörevTeslim()
    {
        if (MersinGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            MersinGörevAçýklama.SetActive(false);
            Altýn += 10;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret += 1;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();
        }

        else if (TarsusGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            TarsusGörevAçýklama.SetActive(false);
            Altýn += 10;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret += 1;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();
        }
        else if (OtelGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            OtelGörevAçýklama.SetActive(false);
            Altýn += 10;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret += 1;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();
        }
        else if (MarketGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            MarketGörevAçýklama.SetActive(false);
            Altýn += 10;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret += 1;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();
        }
        else if (KarakolGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            KarakolGörevAçýklama.SetActive(false);
            Altýn += 10;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret += 1;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();
        }
        else if (ArabaGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            ArabaGörevAçýklama.SetActive(false);
            Altýn += 10;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret += 1;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();
        }
        else if (TamirGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            TamirGörevAçýklama.SetActive(false);
            Altýn += 10;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret += 1;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();
        }
        else if (BankaGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            BankaGörevAçýklama.SetActive(false);
            Altýn += 10;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret += 1;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();
        }
        else if (ÝþMerkeziGörevAçýklama.activeSelf)
        {
            GörevTeslimButton.SetActive(false);
            ÝþMerkeziGörevAçýklama.SetActive(false);
            Altýn += 10;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret += 1;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();
        }
    }
}
