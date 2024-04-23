using System;
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
    public GameObject ArabaGörevYolGöstergesi;
    public GameObject TarsusGörevYolGöstergesi;
    public GameObject YarýþKabul;
    public GameObject yetersiz;
    public GameObject YarýþBaþlangýç80;
    public GameObject YarýþBaþlangýç90;
    public GameObject YarýþBaþlangýç110;
    public GameObject YarýþBitiþ80;
    public GameObject YarýþBitiþ90;
    public GameObject YarýþBitiþ110;
    public GameObject Yarýþcollider;
    public GameObject kazandýnýz80;
    public GameObject kazandýnýz90;
    public GameObject kazandýnýz110;
    public GameObject arabayükseltme70;
    public GameObject arabayükseltme80;
    public GameObject arabayükseltme90;
    public GameObject arabayükseltme100;
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
    public GameObject MersinGörevYeri;
    public GameObject TarsusGörevYeri;
    public GameObject OtelGörevYeri;
    public GameObject MarketGörevYeri;
    public GameObject KarakolGörevYeri;
    public GameObject ArabaGörevYeri;
    public GameObject TamirGörevYeri;
    public GameObject BankaGörevYeri;
    public GameObject ÝþMerkeziGörevYeri;
    public GameObject TarsusÝþMerkeziGörevYeri;
    public List<GameObject> GörevYerleri;
    public List<GameObject> GörevAlma;

    void Start()
    {
        YarýþBaþlangýç80.SetActive(false);
        YarýþBaþlangýç90.SetActive(false);
        YarýþBaþlangýç110.SetActive(false);
        YarýþBitiþ80.SetActive(false);
        YarýþBitiþ90.SetActive(false);
        YarýþBitiþ110.SetActive(false);
        GörevYerleri = new List<GameObject>
        {
            TarsusGörevYeri, MersinGörevYeri, OtelGörevYeri, MarketGörevYeri, KarakolGörevYeri, ArabaGörevYeri, TamirGörevYeri, BankaGörevYeri, ÝþMerkeziGörevYeri, TarsusÝþMerkeziGörevYeri
        };
        GörevAlma = new List<GameObject>
        {
            TarsusGörev, MersinGörev, OtelGörev, MarketGörev, KarakolGörev, ArabaGörev, TamirGörev, BankaGörev, ÝþMerkeziGörev
        };

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
        TarsusGörevYolGöstergesi.SetActive(true);
        TarsusGörevAçýklama.SetActive(true);
        GörevYerleri.Remove(MersinGörevYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = GörevYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = GörevAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void MersinGörevButton()
    {
        MersinGörevAçýklama.SetActive(true);
        GörevYerleri.Remove(TarsusGörevYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = GörevYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = GörevAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void OtelGörevButton()
    {
        OtelGörevAçýklama.SetActive(true);
        GörevYerleri.Remove(MarketGörevYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = GörevYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = GörevAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void MarketGörevButton()
    {
        MarketGörevAçýklama.SetActive(true);
        GörevYerleri.Remove(KarakolGörevYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = GörevYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = GörevAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void KarakolGörevButton()
    {
        KarakolGörevAçýklama.SetActive(true);
        GörevYerleri.Remove(OtelGörevYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = GörevYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = GörevAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void ArabaGörevButton()
    {
        ArabaGörevAçýklama.SetActive(true);
        ArabaGörevYolGöstergesi.SetActive(true);
        GörevYerleri.Remove(TamirGörevYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = GörevYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = GörevAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void TamirGörevButton()
    {
        TamirGörevAçýklama.SetActive(true);
        GörevYerleri.Remove(ArabaGörevYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = GörevYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = GörevAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void BankaGörevButton()
    {
        BankaGörevAçýklama.SetActive(true);
        GörevYerleri.Remove(ÝþMerkeziGörevYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = GörevYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = GörevAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void ÝþMerkeziGörevButton()
    {
        ÝþMerkeziGörevAçýklama.SetActive(true);
        GörevYerleri.Remove(TarsusÝþMerkeziGörevYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = GörevYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = GörevAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void YarýþKabulButton80()
    {
        if (Altýn >= 10 && Þöhret >= 1)
        {
            YarýþBaþlangýç80.SetActive(true);
            YarýþBitiþ80.SetActive(true);
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
    public void YarýþKabulButton90()
    {
        if (Altýn >= 20 && Þöhret >= 2)
        {
            YarýþBaþlangýç90.SetActive(true);
            YarýþBitiþ90.SetActive(true);
            Player.transform.position = new Vector3(123, 2.8f, 526);
            Yarýþcollider.SetActive(true);
            Altýn -= 20;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret -= 2;
            PlayerPrefs.SetInt("Þöhret", Þöhret);
            ÞöhretText.text = Þöhret.ToString();
        }
        else
        {
            yetersiz.SetActive(true);
            YarýþKabul.SetActive(false);
        }
    }
    public void YarýþKabulButton110()
    {
        if(Altýn >= 30 && Þöhret >= 3)
        {
            YarýþBaþlangýç110.SetActive(true);
            YarýþBitiþ110.SetActive(true);
            Player.transform.position = new Vector3(123, 2.8f, 526);
            Yarýþcollider.SetActive(true);
            Altýn -= 30;
            PlayerPrefs.SetInt("Altýn", Altýn);
            AltýnText.text = Altýn.ToString();
            Þöhret -= 3;
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
    public void kazandýnýz80Buton()
    {
        kazandýnýz80.SetActive(false);
        Altýn += 20;
        PlayerPrefs.SetInt("Altýn", Altýn);
        AltýnText.text = Altýn.ToString();
        Þöhret += 2;
        PlayerPrefs.SetInt("Þöhret", Þöhret);
        ÞöhretText.text = Þöhret.ToString();
    }
    public void kazandýnýz90Buton()
    {
        kazandýnýz90.SetActive(false);
        Altýn += 40;
        PlayerPrefs.SetInt("Altýn", Altýn);
        AltýnText.text = Altýn.ToString();
        Þöhret += 4;
        PlayerPrefs.SetInt("Þöhret", Þöhret);
        ÞöhretText.text = Þöhret.ToString();
    }
    public void kazandýnýz110Buton()
    {
        kazandýnýz110.SetActive(false);
        Altýn += 60;
        PlayerPrefs.SetInt("Altýn", Altýn);
        AltýnText.text = Altýn.ToString();
        Þöhret += 6;
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
        if(Altýn >= 60 && Þöhret >= 6)
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
    public void Araba90()
    {
        if (Altýn >= 70 && Þöhret >= 7)
        {
            PrometeoCarController cr = Player.GetComponent<PrometeoCarController>();
            cr.maxSpeed = 100;
            PlayerPrefs.SetInt("maxSpeed", cr.maxSpeed);
        }
        else
        {
            arabayükseltme90.SetActive(false);
            yukseltmeyetersiz.SetActive(true);
        }
    }
    public void Araba100()
    {
        if (Altýn >= 80 && Þöhret >= 8)
        {
            PrometeoCarController cr = Player.GetComponent<PrometeoCarController>();
            cr.maxSpeed = 110;
            PlayerPrefs.SetInt("maxSpeed", cr.maxSpeed);
        }
        else
        {
            arabayükseltme100.SetActive(false);
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
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = GörevYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == false)
            {
                eleman.GetComponent<BoxCollider>().enabled = true;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = GörevAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(true);
            }
        }

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
            TarsusGörevYolGöstergesi.SetActive(false);
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
            ArabaGörevYolGöstergesi.SetActive(false);
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
