using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanDomAll : MonoBehaviour
{
    public GameObject point;
    public GameObject augabat;
    float rndx;
    float rndxA;
    float rndy;
    float rndyA;
    int i;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        rndx = Random.Range(12,-12);
        rndxA = Random.Range(12,-12);
        rndy = Random.Range(3.8f,-3.8f);
        rndyA = Random.Range(3.8f,-3.8f);
        if(i < 5)
        {
            Instantiate(point, new Vector2(rndx, rndy), point.transform.rotation);
        }
        if (i < 9)
        {
            Instantiate(augabat, new Vector2(rndxA, rndyA), augabat.transform.rotation);
        }

    }
}
