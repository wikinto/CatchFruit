using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class keymanager : MonoBehaviour
{
    // Start is called before the first frame update

    public Text gameover;
    void Start()
    {
        if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "GameOver"){
            gameover.text = gameover.text + Globals.score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Jump") >= 1){
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
            Globals.lives = 3;
            Globals.score = 0;
        }
        if (Input.GetKey("escape"))
            Application.Quit();
        
    }
}
