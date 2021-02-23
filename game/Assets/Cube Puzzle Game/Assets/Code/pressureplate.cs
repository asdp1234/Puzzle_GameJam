using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureplate : MonoBehaviour
{
    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag.Equals("P2")|| col.gameObject.tag.Equals("Box"))
        {
            print("on pressure plate");
        }  
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag.Equals("P2") || col.gameObject.tag.Equals("Box"))
        {
            print("off pressure plate");
        }
    }
}