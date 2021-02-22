using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    GameObject cube;
    private void OnTriggerEnter(Collider col)
    {
        if (this.tag.Equals("North") && col.gameObject.tag.Equals("P1"))
        {
            Debug.Log("North");
        }
        if (this.tag.Equals("South") && col.gameObject.tag.Equals("P1"))
        {
            Debug.Log("South");
        }
        if (this.tag.Equals("East") && col.gameObject.tag.Equals("P1"))
        {
            Debug.Log("East");
        }
        if (this.tag.Equals("West") && col.gameObject.tag.Equals("P1"))
        {
            Debug.Log("West");
        }
    }
}
