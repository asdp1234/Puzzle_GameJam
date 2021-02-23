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
        if (controler.isGrounded)
        {
            val.y = -2.0f;
            isground = true;
        }
        else
        {
            isground = false;
        }
        val.y += gravity * Time.deltaTime;

        controler.Move(val * Time.deltaTime);
        if (this.tag == "P1" && active1)
        {
            //val.y = -2.0f;

           // val.y += gravity * Time.deltaTime;

           // controler.Move(val * Time.deltaTime);
            multi();
        }
        if (this.tag == "P2" && active2)
        {
           
            multi();

            if (Input.GetButtonDown("Jump") && isground)
            {
                val.y = Mathf.Sqrt(jumph * -2 * gravity);
                isground = false;
            }
            val.y += gravity * Time.deltaTime;

            controler.Move(val * Time.deltaTime);
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
        if (this.gameObject.transform.position.y < -10)
        {
            this.transform.position = new Vector3(-6,0,-3.3f);
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
