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
    public GameObject ArabaG�revYolG�stergesi;
    public GameObject TarsusG�revYolG�stergesi;
    public GameObject Yar��Kabul;
    public GameObject yetersiz;
    public GameObject Yar��Ba�lang��80;
    public GameObject Yar��Ba�lang��90;
    public GameObject Yar��Ba�lang��110;
    public GameObject Yar��Biti�80;
    public GameObject Yar��Biti�90;
    public GameObject Yar��Biti�110;
    public GameObject Yar��collider;
    public GameObject kazand�n�z80;
    public GameObject kazand�n�z90;
    public GameObject kazand�n�z110;
    public GameObject arabay�kseltme70;
    public GameObject arabay�kseltme80;
    public GameObject arabay�kseltme90;
    public GameObject arabay�kseltme100;
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
    public GameObject MersinG�revYeri;
    public GameObject TarsusG�revYeri;
    public GameObject OtelG�revYeri;
    public GameObject MarketG�revYeri;
    public GameObject KarakolG�revYeri;
    public GameObject ArabaG�revYeri;
    public GameObject TamirG�revYeri;
    public GameObject BankaG�revYeri;
    public GameObject ��MerkeziG�revYeri;
    public GameObject Tarsus��MerkeziG�revYeri;
    public List<GameObject> G�revYerleri;
    public List<GameObject> G�revAlma;

    void Start()
    {
        Yar��Ba�lang��80.SetActive(false);
        Yar��Ba�lang��90.SetActive(false);
        Yar��Ba�lang��110.SetActive(false);
        Yar��Biti�80.SetActive(false);
        Yar��Biti�90.SetActive(false);
        Yar��Biti�110.SetActive(false);
        G�revYerleri = new List<GameObject>
        {
            TarsusG�revYeri, MersinG�revYeri, OtelG�revYeri, MarketG�revYeri, KarakolG�revYeri, ArabaG�revYeri, TamirG�revYeri, BankaG�revYeri, ��MerkeziG�revYeri, Tarsus��MerkeziG�revYeri
        };
        G�revAlma = new List<GameObject>
        {
            TarsusG�rev, MersinG�rev, OtelG�rev, MarketG�rev, KarakolG�rev, ArabaG�rev, TamirG�rev, BankaG�rev, ��MerkeziG�rev
        };

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
        TarsusG�revYolG�stergesi.SetActive(true);
        TarsusG�revA��klama.SetActive(true);
        G�revYerleri.Remove(MersinG�revYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = G�revYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = G�revAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void MersinG�revButton()
    {
        MersinG�revA��klama.SetActive(true);
        G�revYerleri.Remove(TarsusG�revYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = G�revYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = G�revAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void OtelG�revButton()
    {
        OtelG�revA��klama.SetActive(true);
        G�revYerleri.Remove(MarketG�revYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = G�revYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = G�revAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void MarketG�revButton()
    {
        MarketG�revA��klama.SetActive(true);
        G�revYerleri.Remove(KarakolG�revYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = G�revYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = G�revAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void KarakolG�revButton()
    {
        KarakolG�revA��klama.SetActive(true);
        G�revYerleri.Remove(OtelG�revYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = G�revYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = G�revAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void ArabaG�revButton()
    {
        ArabaG�revA��klama.SetActive(true);
        ArabaG�revYolG�stergesi.SetActive(true);
        G�revYerleri.Remove(TamirG�revYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = G�revYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = G�revAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void TamirG�revButton()
    {
        TamirG�revA��klama.SetActive(true);
        G�revYerleri.Remove(ArabaG�revYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = G�revYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = G�revAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void BankaG�revButton()
    {
        BankaG�revA��klama.SetActive(true);
        G�revYerleri.Remove(��MerkeziG�revYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = G�revYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = G�revAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void ��MerkeziG�revButton()
    {
        ��MerkeziG�revA��klama.SetActive(true);
        G�revYerleri.Remove(Tarsus��MerkeziG�revYeri);
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = G�revYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == true)
            {
                eleman.GetComponent<BoxCollider>().enabled = false;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = G�revAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(false);
            }
        }
    }
    public void Yar��KabulButton80()
    {
        if (Alt�n >= 10 && ��hret >= 1)
        {
            Yar��Ba�lang��80.SetActive(true);
            Yar��Biti�80.SetActive(true);
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
    public void Yar��KabulButton90()
    {
        if (Alt�n >= 20 && ��hret >= 2)
        {
            Yar��Ba�lang��90.SetActive(true);
            Yar��Biti�90.SetActive(true);
            Player.transform.position = new Vector3(123, 2.8f, 526);
            Yar��collider.SetActive(true);
            Alt�n -= 20;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret -= 2;
            PlayerPrefs.SetInt("��hret", ��hret);
            ��hretText.text = ��hret.ToString();
        }
        else
        {
            yetersiz.SetActive(true);
            Yar��Kabul.SetActive(false);
        }
    }
    public void Yar��KabulButton110()
    {
        if(Alt�n >= 30 && ��hret >= 3)
        {
            Yar��Ba�lang��110.SetActive(true);
            Yar��Biti�110.SetActive(true);
            Player.transform.position = new Vector3(123, 2.8f, 526);
            Yar��collider.SetActive(true);
            Alt�n -= 30;
            PlayerPrefs.SetInt("Alt�n", Alt�n);
            Alt�nText.text = Alt�n.ToString();
            ��hret -= 3;
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
    public void kazand�n�z80Buton()
    {
        kazand�n�z80.SetActive(false);
        Alt�n += 20;
        PlayerPrefs.SetInt("Alt�n", Alt�n);
        Alt�nText.text = Alt�n.ToString();
        ��hret += 2;
        PlayerPrefs.SetInt("��hret", ��hret);
        ��hretText.text = ��hret.ToString();
    }
    public void kazand�n�z90Buton()
    {
        kazand�n�z90.SetActive(false);
        Alt�n += 40;
        PlayerPrefs.SetInt("Alt�n", Alt�n);
        Alt�nText.text = Alt�n.ToString();
        ��hret += 4;
        PlayerPrefs.SetInt("��hret", ��hret);
        ��hretText.text = ��hret.ToString();
    }
    public void kazand�n�z110Buton()
    {
        kazand�n�z110.SetActive(false);
        Alt�n += 60;
        PlayerPrefs.SetInt("Alt�n", Alt�n);
        Alt�nText.text = Alt�n.ToString();
        ��hret += 6;
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
        if(Alt�n >= 60 && ��hret >= 6)
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
    public void Araba90()
    {
        if (Alt�n >= 70 && ��hret >= 7)
        {
            PrometeoCarController cr = Player.GetComponent<PrometeoCarController>();
            cr.maxSpeed = 100;
            PlayerPrefs.SetInt("maxSpeed", cr.maxSpeed);
        }
        else
        {
            arabay�kseltme90.SetActive(false);
            yukseltmeyetersiz.SetActive(true);
        }
    }
    public void Araba100()
    {
        if (Alt�n >= 80 && ��hret >= 8)
        {
            PrometeoCarController cr = Player.GetComponent<PrometeoCarController>();
            cr.maxSpeed = 110;
            PlayerPrefs.SetInt("maxSpeed", cr.maxSpeed);
        }
        else
        {
            arabay�kseltme100.SetActive(false);
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
        for (int i = 0; i < 9; i++)
        {
            GameObject eleman = G�revYerleri[i];
            if (eleman.GetComponent<BoxCollider>().enabled == false)
            {
                eleman.GetComponent<BoxCollider>().enabled = true;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            GameObject eleman = G�revAlma[i];
            if (eleman.activeSelf)
            {
                eleman.SetActive(true);
            }
        }

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
            TarsusG�revYolG�stergesi.SetActive(false);
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
            ArabaG�revYolG�stergesi.SetActive(false);
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
