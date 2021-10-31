using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yeniden : MonoBehaviour
{
    public UnityEngine.UI.Text puanin;
    // Start is called before the first frame update
    void Start()
    {
        puanin.text = "Puanýnýz: " + GameObject.FindObjectOfType<puan>().GetComponent<puan>().Puanin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void YenidenOyna()
    {
        tugla.tuglasayisi = 0;
        GameObject.FindObjectOfType<puan>().GetComponent<puan>().PuanSifirla();
        SceneManager.LoadScene("Bolum1");
    }
}
