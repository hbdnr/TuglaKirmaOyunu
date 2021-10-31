using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzikcalma : MonoBehaviour
{
    static bool muzikVarMi;
    // Start is called before the first frame update
    void Start()
    {
        if (!muzikVarMi)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            muzikVarMi = true;
        }
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
