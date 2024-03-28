using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 1000f;
    public float speed = 10f;
    public float maxX;
    public float minX;
    public AudioSource backgroundSource;
    // Start is called before the first frame update
  
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {

        Vector3 playerpos = transform.position;
        playerpos.x = Mathf.Clamp(playerpos.x,minX,maxX);
        transform.position = playerpos;


        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
    private void FixedUpdate()
    {
     rb.AddForce(0, 0, force * Time.deltaTime);
    }
}
