using System;
using UnityEngine;

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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

