using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generalscript : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public GameObject sun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OrbitAround();
    }
    void OrbitAround()
    {
        transform.RotateAround(sun.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
