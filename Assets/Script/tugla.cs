using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tugla : MonoBehaviour
{
    public static int tuglasayisi;
    public Sprite[] tuglaa;
    private int max_carpma;
    private int carpma;
    private puan puanScript;
    // Start is called before the first frame update
    void Start()
    {
        puanScript = GameObject.FindObjectOfType<puan>().GetComponent<puan>();
        max_carpma = tuglaa.Length + 1;
        tuglasayisi++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name.Equals("top"))
        {
            carpma++;
            puanScript.PuanArttir();
            
        }
        if (carpma >= max_carpma)
        {
            Destroy(gameObject);
            tuglasayisi--;
            if (tuglasayisi <= 0)
            {
                GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().BirSonrakiSahne();
            }
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = tuglaa[carpma - 1];
        }
    }
}
