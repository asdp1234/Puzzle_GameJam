using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    GameObject cube;
    private void OnTriggerStay(Collider col)
    {
        if (this.tag.Equals("North") && col.gameObject.tag.Equals("P1"))
        {
            //-z
            Debug.Log("North");
            cube.transform.position = transform.position + new Vector3(0, 0, -1.4f * Time.deltaTime);
        }
        if (this.tag.Equals("South") && col.gameObject.tag.Equals("P1"))
        {
            cube.transform.position = transform.position + new Vector3(0, 0, 1.4f * Time.deltaTime);
            //+z
            Debug.Log("South");
        }
        if (this.tag.Equals("East") && col.gameObject.tag.Equals("P1"))
        {
            cube.transform.position = transform.position + new Vector3(-1.4f * Time.deltaTime, 0, 0);
            //-x
            Debug.Log("East");
        }
        if (this.tag.Equals("West") && col.gameObject.tag.Equals("P1"))
        {
            cube.transform.position = transform.position + new Vector3(1.4f * Time.deltaTime, 0, 0);
            //+x
            Debug.Log("West");
        }
    }
}
