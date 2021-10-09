using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 5.0f;

    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = ball.GetComponent<Rigidbody>();
	rb.AddForce((Vector3.up + Vector3.right) * 300);
    }

    // Update is called once per frame
    void Update()
    {
        float inp = Input.GetAxis("Horizontal") * Time.deltaTime;
        float current_x = transform.position.x;
        float new_x = Mathf.Clamp(current_x + inp, -5.0f, 5.0f);
        transform.position = new Vector3(new_x, transform.position.y, transform.position.z);
    
    	
    }
}
