using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject TarsusG�rev;
    public GameObject MersinG�rev;
    public GameObject G�revTeslimButton;
    public GameObject TarsusG�revA��klama;
    public GameObject MersinG�revA��klama;

    public void TarsusG�revButton()
    {
        TarsusG�revA��klama.SetActive(true);
    }
    public void MersinG�revButton()
    {
        MersinG�revA��klama.SetActive(true);
    }

    public void G�revTeslim()
    {
        if (MersinG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            MersinG�revA��klama.SetActive(false);
        }

        else if (TarsusG�revA��klama.activeSelf)
        {
            G�revTeslimButton.SetActive(false);
            TarsusG�revA��klama.SetActive(false);

        }
    }
}
