using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        print("test start");
    }

    // Update is called once per frame
    void Update()
    {
        print(speed);
    }
}
