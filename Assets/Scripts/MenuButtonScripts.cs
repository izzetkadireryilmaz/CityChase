using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuButtonScripts : MonoBehaviour
{
    public GameObject YeniOyunEkraný;
    public GameObject MenuButon;
    public void YeniOyun()
    {
        PlayerPrefs.SetInt("Altýn", 0);
        PlayerPrefs.SetInt("Þöhret", 0);
        PlayerPrefs.SetInt("maxSpeed", 70);
        PlayerPrefs.Save();
    }

    public void DevamEtButon()
    {
        SceneManager.LoadScene(1);
    }
    public void YeniOyunButon()
    {
       YeniOyunEkraný.SetActive(true);
       MenuButon.SetActive(false);
    }
    
    public void QuitButton()
    {
        Application.Quit();
    }

    public void Kabul()
    {
        SceneManager.LoadScene(1);
        YeniOyun();
    }
    public void Ret()
    {
        YeniOyunEkraný.SetActive(false);
        MenuButon.SetActive(true);
    }
}
