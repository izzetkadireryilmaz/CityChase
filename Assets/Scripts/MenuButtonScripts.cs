using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuButtonScripts : MonoBehaviour
{
    public GameObject YeniOyunEkranı;
    public GameObject MenuButon;
    public void YeniOyun()
    {
        PlayerPrefs.SetInt("Altın", 0);
        PlayerPrefs.Save();
    }

    public void DevamEtButon()
    {
        SceneManager.LoadScene(1);
    }
    public void YeniOyunButon()
    {
       YeniOyunEkranı.SetActive(true);
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
        YeniOyunEkranı.SetActive(false);
        MenuButon.SetActive(true);
    }
}
