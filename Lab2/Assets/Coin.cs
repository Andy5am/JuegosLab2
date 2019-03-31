using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
         start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0, Time.deltaTime * 50, 0);
        transform.position = start+ new Vector3(0, Mathf.Sin(Time.time)*1/4, 0);
    }

}
