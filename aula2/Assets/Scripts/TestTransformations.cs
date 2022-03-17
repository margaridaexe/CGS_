using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransformations : MonoBehaviour
{
    //Declarar Variaveis
    Vector3 move = new Vector3(5, -1, 0);
    Vector3 rotate = new Vector3(0, 90, 0);

    // Start is called before the first frame update
    void Start()
    {

        //transform.Rotate(rotate);
        transform.Translate(move);

        Debug.Log("Local Scale: " + transform.localScale + "\n" +
            "Local Position: " + transform.localPosition + "\n" +
            "Local Rotation: " + transform.localEulerAngles + "\n" +
            "Global Scale: " + transform.lossyScale + "\n" +
            "Global Position: " + transform.position + "\n" +
            "Global Rotation: " + transform.eulerAngles);
    }

    // Update is called once per frame  // not used
    void Update()
    {
        float mover = 1;
        move.Set(0, mover+1, 0);
        transform.Rotate(move);
    }
}
