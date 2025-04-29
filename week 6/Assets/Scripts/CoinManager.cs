using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public GameObject ObjCenter;
    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(ObjCenter.transform.position, Vector3.up, 15 * Time.deltaTime);
    }
}
