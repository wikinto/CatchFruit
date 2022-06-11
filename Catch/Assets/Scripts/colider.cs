using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Globals{
    public static int score = 0;
    public static int lives = 3;
}
public class colider : MonoBehaviour
{
    public Text punkty;
    public Text zycia;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        zycia.text = "Zycia: " + Globals.lives.ToString();
        if(Globals.lives <= 0){
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
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
                Globals.score++;
                break;
            case "brick":
                Globals.lives--;
                break;
            default:
                break;
        }
        punkty.text = "Punkty: " + Globals.score.ToString();
        
    }
}
