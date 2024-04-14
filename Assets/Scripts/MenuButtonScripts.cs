using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuButtonScripts : MonoBehaviour
{
    public GameObject YeniOyunEkran�;
    public GameObject MenuButon;
    public GameObject MenuCanvas;
    public GameObject StoryCanvas;
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
        StoryCanvas.SetActive(true);
        MenuCanvas.SetActive(false);
        YeniOyun();
    }
    public void Ret()
    {
        YeniOyunEkran�.SetActive(false);
        MenuButon.SetActive(true);
    }

    void Update()
    {
        StartCoroutine(Baslangic());
    }

    IEnumerator Baslangic()
    {
        yield return new WaitForSeconds(50f);
        SceneManager.LoadScene(1);
        StoryCanvas.SetActive(false);
    }
}
