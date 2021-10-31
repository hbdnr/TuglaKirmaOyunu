using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedal : MonoBehaviour
{
    private GameObject topp;
    // Start is called before the first frame update
    void Start()
    {
        topp = GameObject.Find("top");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20f));
        //transform.position = new Vector3(farePos.x, transform.position.y, transform.position.z);
        transform.position = new Vector3(topp.transform.position.x, transform.position.y, transform.position.z);
    }
}
