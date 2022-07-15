using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    float delta = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > 0.5f) {
            delta = 0;
            Debug.Log(Input.acceleration.x + "  "+ Input.acceleration.y+" "+ Input.acceleration.z);
        }
    }
}
