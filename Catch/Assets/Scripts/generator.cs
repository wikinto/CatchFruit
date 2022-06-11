using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class generator : MonoBehaviour
{
    int x;
    
    public GameObject[] objs;
    int rand;
    GameObject inst;
    GameObject prev;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawner());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(prev.gameObject.tag == "apple" && prev.transform.position.y <= -3 && prev != null){
            Globals.lives--;
        }
        if(prev.transform.position.y <= -3 && prev != null){
            Destroy(prev);
        }
    }
    IEnumerator spawner(){
        while (true)
        {
            x = Random.Range(-8, 8);
            Debug.Log(x);
            inst = Instantiate(objs[Random.Range(0,3)], new Vector3(x, 15, 0), new Quaternion(Random.Range(0,360),Random.Range(0,360),Random.Range(0,360),Random.Range(0,360)));
            yield return new WaitForSeconds(2);
            prev = inst;
        }
    }
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
}
