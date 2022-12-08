using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(0,0,1);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(0,0,-1);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-1,0,0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(1,0,0);
            }

            if(transform.position.y < -10)
            {
                transform.position = new Vector3(0,10,0);
            }
            
            
    }
    void OnCollisionStay(Collision hit)
            {
                if(hit.gameObject.tag == "Enemy")
                {
                    transform.position = new Vector3(0,10,0);
                }
                if(hit.gameObject.tag == "Goal")
                {
                    transform.position = new Vector3(55.7f,4.7f,-2.56f);
               
                 } 
    }

           
}
