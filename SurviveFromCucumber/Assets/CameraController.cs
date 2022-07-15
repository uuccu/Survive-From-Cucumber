using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("type") == "cucumber") target = GameObject.Find("Cucumber");
        else if (PlayerPrefs.GetString("type") == "human") target = GameObject.Find("Human");
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetPositionAndRotation(this.target.transform.position, this.target.transform.rotation);
        transform.Translate(0, 1, -5);
    }
}
