using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    void Update()
    {
        ab();
    }

    void ab()
    {
        if(Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Began)
        {
            Debug.Log("Whotho");
        }
    }
}
