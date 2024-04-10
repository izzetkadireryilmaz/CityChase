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
    public int Altýn;
    public Text AltýnText;
    public int Þöhret;
    public Text ÞöhretText;
    public int maxSpeed;
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
    public GameObject kazandýnýz;
    public GameObject arabayükseltme70;
    public GameObject arabayükseltme80;
    public GameObject yukseltmeyetersiz;
    public GameObject ayarlaraç;
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
        if(Altýn >= 10 && Þöhret >= 1)
        {
            Player.transform.position = new Vector3(123, 2.8f, 526);
            Yarýþcollider.SetActive(true);
            Altýn -= 10;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret -= 1;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();

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
        yukseltmeyetersiz.SetActive(false);
    }
    public void kazandýnýzButon()
    {
        kazandýnýz.SetActive(false);
        Altýn += 20;
        PlayerPrefs.SetInt("Altýn", Altýn);
        AltýnText.text = Altýn.ToString();
        Þöhret += 2;
        PlayerPrefs.SetInt("Þöhret", Þöhret);
        ÞöhretText.text = Þöhret.ToString();
    }
    public void Araba70()
    {
        if(Altýn >= 30 && Þöhret >= 5)
        {
             PrometeoCarController cr = Player.GetComponent<PrometeoCarController>();
             cr.maxSpeed = 80;
             PlayerPrefs.SetInt("maxSpeed", cr.maxSpeed);
        }
        else
        {
             arabayükseltme70.SetActive(false);
             yukseltmeyetersiz.SetActive(true);
        }
    }
    public void Araba80()
    {
        if(Altýn >= 60 && Þöhret >= 9)
        {
            PrometeoCarController cr = Player.GetComponent<PrometeoCarController>();
            cr.maxSpeed = 90;
            PlayerPrefs.SetInt("maxSpeed", cr.maxSpeed);
        }
        else
        {
            arabayükseltme80.SetActive(false);
            yukseltmeyetersiz.SetActive(true);
        }
    }
    public void AyarlarButton()
    {
        ayarlaraç.SetActive(false);
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
        ayarlaraç.SetActive(true);
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
