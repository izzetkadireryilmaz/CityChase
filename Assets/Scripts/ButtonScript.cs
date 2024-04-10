using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ButtonScript : MonoBehaviour
{
    public int Alt�n;
    public Text Alt�nText;
    public int ��hret;
    public Text ��hretText;
    public int maxSpeed;
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
    public GameObject Yar��Kabul;
    public GameObject yetersiz;
    public GameObject Yar��collider;
    public GameObject kazand�n�z;
    public GameObject arabay�kseltme70;
    public GameObject arabay�kseltme80;
    public GameObject yukseltmeyetersiz;
    public GameObject ayarlara�;
    public GameObject ayarlarkapat;
    public GameObject menu;
    public GameObject sound;
    public GameObject soundmute;
    public GameObject music;
    public GameObject musicmute;
    public GameObject GameMusic;
    public GameObject CarSound;

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

        if (PlayerPrefs.HasKey("��hret"))
        {
            ��hret = PlayerPrefs.GetInt("��hret");
            ��hretText.text = ��hret.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("��hret", 0);
            ��hretText.text = PlayerPrefs.GetInt("��hret").ToString();
        }

        if (PlayerPrefs.HasKey("maxSpeed"))
        {
            PrometeoCarController cr = Player.GetComponent<PrometeoCarController>();
            cr.maxSpeed = PlayerPrefs.GetInt("maxSpeed");
        }
        else
        {
            PlayerPrefs.SetInt("maxSpeed", 0);
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
    public void Yar��KabulButton()
    {
        if(Alt�n >= 10 && ��hret >= 1)
        {
            Player.transform.position = new Vector3(123, 2.8f, 526);
            Yar��collider.SetActive(true);
            Alt�n -= 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret -= 1;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();

        }
        else
        {
            yetersiz.SetActive(true);
            Yar��Kabul.SetActive(false);
        }
    }
    public void YetersizKapat()
    {
        yetersiz.SetActive(false);
        yukseltmeyetersiz.SetActive(false);
    }
    public void kazand�n�zButon()
    {
        kazand�n�z.SetActive(false);
        Alt�n += 20;
        PlayerPrefs.SetInt("Alt�n", Alt�n);
        Alt�nText.text = Alt�n.ToString();
        ��hret += 2;
        PlayerPrefs.SetInt("��hret", ��hret);
        ��hretText.text = ��hret.ToString();
    }
    public void Araba70()
    {
        if(Alt�n >= 30 && ��hret >= 5)
        {
             PrometeoCarController cr = Player.GetComponent<PrometeoCarController>();
             cr.maxSpeed = 80;
             PlayerPrefs.SetInt("maxSpeed", cr.maxSpeed);
        }
        else
        {
             arabay�kseltme70.SetActive(false);
             yukseltmeyetersiz.SetActive(true);
        }
    }
    public void Araba80()
    {
        if(Alt�n >= 60 && ��hret >= 9)
        {
            PrometeoCarController cr = Player.GetComponent<PrometeoCarController>();
            cr.maxSpeed = 90;
            PlayerPrefs.SetInt("maxSpeed", cr.maxSpeed);
        }
        else
        {
            arabay�kseltme80.SetActive(false);
            yukseltmeyetersiz.SetActive(true);
        }
    }
    public void AyarlarButton()
    {
        ayarlara�.SetActive(false);
        ayarlarkapat.SetActive(true);
        if (GameMusic.gameObject.activeSelf)
        {
            menu.SetActive(true);
            musicmute.SetActive(false);
            music.SetActive(true);
            if (CarSound.gameObject.activeSelf)
            {
                soundmute.SetActive(false);
                sound.SetActive(true);
            }
            else
            {
                sound.SetActive(false);
                soundmute.SetActive(true);
            }
        }
        else
        {
            menu.SetActive(true);
            music.SetActive(false);
            musicmute.SetActive(true);
            if (CarSound.gameObject.activeSelf)
            {
                sound.SetActive(true);
            }
            else
            {
                soundmute.SetActive(true);
            }
        }
    }
    public void AyarlarKapatButon()
    {
        ayarlara�.SetActive(true);
        ayarlarkapat.SetActive(false);  
        menu.SetActive(false);
        sound.SetActive(false);
        music.SetActive(false);
        soundmute.SetActive(false);
        musicmute.SetActive(false);
    }
    public void SoundButton()
    {
        CarSound.SetActive(false);
        sound.SetActive(false);
        soundmute.SetActive(true);
    }
    public void SoundMuteButton()
    {
        CarSound.SetActive(true);
        sound.SetActive(true);
        soundmute.SetActive(false);
    }
    public void MusicButon()
    {
        GameMusic.SetActive(false);
        music.SetActive(false);
        musicmute.SetActive(true);
    }
    public void MusicMuteButon()
    {
        GameMusic.SetActive(true);
        music.SetActive(true);
        musicmute.SetActive(false);
    }
    public void MenuButon()
    {
        SceneManager.LoadScene(0);
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
            ��hret += 1;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();
        }

        else if (TarsusG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            TarsusG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret += 1;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();
        }
        else if (OtelG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            OtelG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret += 1;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();
        }
        else if (MarketG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            MarketG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret += 1;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();
        }
        else if (KarakolG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            KarakolG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret += 1;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();
        }
        else if (ArabaG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            ArabaG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret += 1;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();
        }
        else if (TamirG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            TamirG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret += 1;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();
        }
        else if (BankaG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            BankaG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret += 1;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();
        }
        else if (��MerkeziG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            ��MerkeziG�revA��klama.SetActive(false);
            Alt�n += 10;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret += 1;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();
        }
    }
}
