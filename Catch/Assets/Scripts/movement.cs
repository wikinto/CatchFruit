using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Transform ply;
    float x;
    // Start is called before the first frame update
    void Start()
    {
        ply = GetComponentInParent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x += Input.GetAxis("Horizontal") * 0.5f;
        //Debug.Log(Input.GetAxis("Horizontal"));
        
        ply.transform.position = new Vector3(x,0,0);
    }
}
