using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightControl : MonoBehaviour
{
    Vector3 move = new Vector3(0, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        move.Set(180, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        float one = 1;
        move.Set(0, one+0.00324f, 0);
        transform.Rotate(move);

    }
}
