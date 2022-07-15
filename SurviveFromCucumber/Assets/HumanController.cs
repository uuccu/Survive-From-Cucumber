using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("type") != "human") return;
        transform.Translate(0, 0, 0.25f);
        transform.Rotate(new Vector3(0, Input.acceleration.x * 10, 0));
    }
}
