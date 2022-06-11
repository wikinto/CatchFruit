using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colider : MonoBehaviour
{
    public Text punkty;
    public Text zycia;
    int score;
    int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        
        Destroy(other.gameObject);
        switch (other.gameObject.tag)
        {
            case "apple":
                score++;
                break;
            case "brick":
                lives--;
                break;
            default:
                break;
        }
        
        if(lives <= 0){
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
        punkty.text = "Punkty: " + score.ToString();
        zycia.text = "Zycia: " + lives.ToString();
        Debug.Log(score);
        
    }
}
