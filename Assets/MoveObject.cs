using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject yellowSphere;
    public GameObject sphere;
    public float deg=0;
    public float sinDeg;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deg+=Time.deltaTime*4;
        yellowSphere.transform.rotation=Quaternion.Euler(new Vector3(0,0,45f*deg));
        sphere.transform.rotation=Quaternion.Euler(new Vector3(0,0,-45f*deg));
        sinDeg=Mathf.Sin(Time.time);
        transform.position=new Vector3(transform.position.x,transform.position.y,sinDeg*4f);
    }
}
