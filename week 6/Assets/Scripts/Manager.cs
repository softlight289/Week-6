using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject ObjectA;
    public GameObject ObjectB;
    public GameObject ObjectC;

    // Start is called before the first frame update
    void Start()
    {
        ObjectA.SetActive(false);
        ObjectB.SetActive(true);
        ObjectC.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
