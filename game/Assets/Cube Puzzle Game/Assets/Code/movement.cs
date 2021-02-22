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

    bool active1 = true, active2 = false;

    float speed = 12;
    [SerializeField]
    Vector3 val;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "P1" && active1)
        {
            multi();
        }
        if (this.tag == "P2" && active2)
        {
            multi();
        }
        

    }

    void multi()
    {
        val.y = -2.0f;

        xyz.x = Input.GetAxis("Horizontal");
        xyz.z = Input.GetAxis("Vertical");

        move = transform.right * xyz.x + transform.forward * xyz.z;

        controler.Move(move * speed * Time.deltaTime);


        val.y += gravity * Time.deltaTime;

        controler.Move(val * Time.deltaTime);

    }

}
