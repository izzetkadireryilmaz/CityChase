using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
    [SerializeField] TextMeshProUGUI timerText;
    public float GecenSure;
    public bool yarista;
    public GameObject kazandınız;
    public GameObject ArabaGüçlendirme70;
    public GameObject ArabaGüçlendirme80;

    private void Start()
    {
        timerText.gameObject.SetActive(false);
        yarista = false;
    }
    void Update()
    {
        GecenSure += Time.deltaTime;
        int minutes = Mathf.FloorToInt(GecenSure / 60);
        int seconds = Mathf.FloorToInt(GecenSure % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if(GecenSure > 110)
        {   
            GecenSure = 0;

            if (yarista == true)
            {
                transform.position = new Vector3(255, 0, 60);
                transform.rotation = new Quaternion(0, 0, 0, 0);
                yarista = false;
                timerText.gameObject.SetActive(false);
            }
        }

    }

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
            yarista = false;
            timerText.gameObject.SetActive(false);
            transform.position = new Vector3(255,0,60);
            transform.rotation = new Quaternion(0,0,0,0);
        }
        if (other.gameObject.tag == "YarışBaşlangıç")
        {
            yarista = true;
            timerText.gameObject.SetActive(true);
            GecenSure = 0;
            Update();
        }
        if (other.gameObject.tag == "YarışBitiş")
        {
            yarista = false;
            timerText.gameObject.SetActive(false);
            GecenSure = 0;
            transform.position = new Vector3(255, 0, 60);
            transform.rotation = new Quaternion(0, 0, 0, 0);
            kazandınız.SetActive(true);
        }
        if (other.gameObject.tag == "ArabaGüçlendirme")
        {
            PrometeoCarController cr = GetComponent<PrometeoCarController>();
            if (cr.maxSpeed == 70)
            {
                ArabaGüçlendirme70.SetActive(true);
            }
            if (cr.maxSpeed == 80)
            {
                ArabaGüçlendirme80.SetActive(true);
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
        if (other.gameObject.tag == "ArabaGüçlendirme")
        {
            ArabaGüçlendirme70.SetActive(false);
            ArabaGüçlendirme80.SetActive(false);
        }

    }
}
