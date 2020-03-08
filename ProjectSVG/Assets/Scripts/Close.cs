using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public bool Closed;
    // Start is called before the first frame update
    void Start()
    {
        Closed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape)) { Closed = !Closed; }
        if (Closed) { Debug.Log("Exception Negative"); }
    }
}