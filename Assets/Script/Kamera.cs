using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        transform.position = new Vector3(pos[0], pos[1], pos[2] - 7);
        //transform.position = transform.position + new Vector3(0, 10, 0);

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 KamaraPos = transform.position;
        

        transform.position = new Vector3(pos[0], pos[1], pos[2]- 7);
    }
}
