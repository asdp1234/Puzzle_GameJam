using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    Vector3 xyz;

    Vector3 move;

    public CharacterController controler;
    public float gravity = -9.81f;
    public float grounddis= .4f;
    public LayerMask groundmask;
    [SerializeField]
    bool isground = true;

    public float jumph = 1.5f;
    [SerializeField]
    int jumpnum = 1;
    [SerializeField]
    bool active1 = true, active2 = false;

    float speed = 12;
    [SerializeField]
    Vector3 val;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        val.y = -2.0f;

        val.y += gravity * Time.deltaTime;

        controler.Move(val * Time.deltaTime);

        if (this.tag == "P1" && active1)
        {
            multi();
        }
        if (this.tag == "P2" && active2)
        {
            multi();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            if (active1)
            {
                active2 = true;
                active1 = false;
            }
            else
            {
                active2 = false;
                active1 = true;
            }
        }

    }

    void multi()
    {

        xyz.x = Input.GetAxis("Horizontal");
        xyz.z = Input.GetAxis("Vertical");

        move = transform.right * xyz.x + transform.forward * xyz.z;

        controler.Move(move * speed * Time.deltaTime);

        

    }

}
