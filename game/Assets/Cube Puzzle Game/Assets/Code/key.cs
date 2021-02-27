using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    bool exit;
    private void Start()
    {
        exit = false;
    }
    private void OnTriggerEnter(Collider col)
    {
        if ( col.gameObject.tag.Equals("P1")|| col.gameObject.tag.Equals("P2"))
        {
            exit = true;
            Destroy(this.gameObject);
        }
       
    }
}