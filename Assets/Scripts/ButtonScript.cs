using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ButtonScript : MonoBehaviour
{
    public int Alt�n;
    public Text Alt�nText;
    public GameObject Player;
    public GameObject TarsusG�rev;
    public GameObject MersinG�rev;
    public GameObject OtelG�rev;
    public GameObject MarketG�rev;
    public GameObject KarakolG�rev;
    public GameObject ArabaG�rev;
    public GameObject TamirG�rev;
    public GameObject BankaG�rev;
    public GameObject ��MerkeziG�rev;
    public GameObject G�revTeslimButton;
    public GameObject TarsusG�revA��klama;
    public GameObject MersinG�revA��klama;
    public GameObject OtelG�revA��klama;
    public GameObject MarketG�revA��klama;
    public GameObject KarakolG�revA��klama;
    public GameObject ArabaG�revA��klama;
    public GameObject TamirG�revA��klama;
    public GameObject BankaG�revA��klama;
    public GameObject ��MerkeziG�revA��klama;


    void Start()
    {
        if (PlayerPrefs.HasKey("Alt�n"))
        {
            Alt�n = PlayerPrefs.GetInt("Alt�n");
            Alt�nText.text = Alt�n.ToString() + " Alt�n";
        }
        else
        {
            PlayerPrefs.SetInt("Alt�n", 0);
            Alt�nText.text = PlayerPrefs.GetInt("Alt�n").ToString() + " Alt�n";
        }
    }
    public void TarsusG�revButton()
    {
        TarsusG�revA��klama.SetActive(true);
    }
    public void MersinG�revButton()
    {
        MersinG�revA��klama.SetActive(true);
    }
    public void OtelG�revButton()
    {
        OtelG�revA��klama.SetActive(true);
    }
    public void MarketG�revButton()
    {
        MarketG�revA��klama.SetActive(true);
    }
    public void KarakolG�revButton()
    {
        KarakolG�revA��klama.SetActive(true);
    }
    public void ArabaG�revButton()
    {
        ArabaG�revA��klama.SetActive(true);
    }
    public void TamirG�revButton()
    {
        TamirG�revA��klama.SetActive(true);
    }
    public void BankaG�revButton()
    {
        BankaG�revA��klama.SetActive(true);
    }
    public void ��MerkeziG�revButton()
    {
        ��MerkeziG�revA��klama.SetActive(true);
    }


    public void G�revTeslim()
    {
        if (MersinG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            MersinG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
        }

        else if (TarsusG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            TarsusG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
        }
        else if (OtelG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            OtelG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
        }
        else if (MarketG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            MarketG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
        }
        else if (KarakolG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            KarakolG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
        }
        else if (ArabaG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            ArabaG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
        }
        else if (TamirG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            TamirG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
        }
        else if (BankaG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            BankaG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
        }
        else if (��MerkeziG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            ��MerkeziG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
        }
    }
}
