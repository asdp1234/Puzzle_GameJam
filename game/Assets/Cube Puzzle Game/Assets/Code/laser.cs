using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    [SerializeField]
    LineRenderer lr;
    [SerializeField]
    GameObject point1,point2;
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 startPos = lr.GetPosition(0);
        Vector3 endPos = lr.GetPosition(lr.positionCount - 1);

        lr.SetPosition(0, point1.transform.position);
       
        
        RaycastHit hit;
       
        if (Physics.Raycast(point1.transform.position, transform.forward, out hit))
        {
          if (hit.collider)
          {
            lr.SetPosition(1, hit.point);
            print("test");
          }
        }
        else
        {
                lr.SetPosition(1, point1.transform.forward*5000);
        }
       

    }
}
