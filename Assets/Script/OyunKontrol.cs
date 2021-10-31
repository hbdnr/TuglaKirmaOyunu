using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BirSonrakiSahne()
    {
        tugla.tuglasayisi = 0;
        GameObject.FindObjectOfType<puan>().GetComponent<puan>().PuanSifirla();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
