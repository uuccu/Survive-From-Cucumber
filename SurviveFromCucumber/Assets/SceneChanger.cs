using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void OnClickCucumber() {
        PlayerPrefs.SetString("type", "cucumber");
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickHuman() {
        PlayerPrefs.SetString("type", "human");
        SceneManager.LoadScene("GameScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
