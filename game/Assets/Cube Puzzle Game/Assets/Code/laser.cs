using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    [SerializeField]
    LineRenderer lr;
    [SerializeField]
    GameObject point1,point2;
    [SerializeField]
    GameObject player1,respawnpoint;
    // Start is called before the first frame update
    private void Start()
    {
        //player1 = player1.GetComponent<movement>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 startPos = lr.GetPosition(0);
        Vector3 endPos = lr.GetPosition(lr.positionCount - 1);

        lr.SetPosition(0, point1.transform.position);
        lr.SetPosition(1, point2.transform.position);


        RaycastHit hit;
       
        if (Physics.Raycast(point1.transform.position, transform.forward, out hit))
        {
          
          if (hit.collider)
          {
               if (hit.collider.gameObject.tag.Equals("P1"))
               {

                    // respwn
                    Destroy(hit.collider.gameObject);


               }
                if (hit.collider && !hit.collider.gameObject.tag.Equals("P1"))
                {
                    
                    print("No");
                    print(hit.collider.gameObject.tag);
                    lr.SetPosition(1, hit.point);
                     print("test");
                }
                //  else
                //{
                //    
                // }
            }
        }
        else
        {
          lr.SetPosition(1, point2.transform.position);
        }
       

    }
}
