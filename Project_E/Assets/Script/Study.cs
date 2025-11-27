using System;
using UnityEngine;

using Random = UnityEngine.Random;

public class Study : MonoBehaviour
{
    public string say = "";
    public char text;
    public int var = 1;
    public float var02 = 0.4f;
    public double var03 = 0.5;
    public bool var04 = true;

    void Start()
    {
        Debug.Log(this.say);
        Debug.Log(this.text);


        Debug.Log(Random.Range(0, 100));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

