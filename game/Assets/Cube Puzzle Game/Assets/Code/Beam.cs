using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag.Equals("P1") || col.gameObject.tag.Equals("Box"))
        {
            
        }
        if (col.gameObject.tag.Equals("P2"))
        {
            print("ded");
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag.Equals("P1") || col.gameObject.tag.Equals("Box"))
        {
           
        }
    }
}
