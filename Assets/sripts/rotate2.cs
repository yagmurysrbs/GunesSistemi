using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate2 : MonoBehaviour
{
    public Vector3 yon;
    void Start()
    {
        yon = new Vector3(0, 0.2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.2f, 0);
    }

}
