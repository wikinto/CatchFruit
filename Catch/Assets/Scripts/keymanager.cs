using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keymanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Jump") >= 1){
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}