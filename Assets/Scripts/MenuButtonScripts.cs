using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuButtonScripts : MonoBehaviour
{
    public GameObject YeniOyunEkran�;
    public GameObject MenuButon;
    public void YeniOyun()
    {
        PlayerPrefs.SetInt("Alt�n", 0);
        PlayerPrefs.SetInt("��hret", 0);
        PlayerPrefs.SetInt("maxSpeed", 70);
        PlayerPrefs.Save();
    }

    public void DevamEtButon()
    {
        SceneManager.LoadScene(1);
    }
    public void YeniOyunButon()
    {
       YeniOyunEkran�.SetActive(true);
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
        YeniOyunEkran�.SetActive(false);
        MenuButon.SetActive(true);
    }
}
