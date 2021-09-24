using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    [SerializeField] private float speed = 10;
    [SerializeField] private float maxMovement = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
	
	float oldX = transform.position.x;
	float newX = oldX + input;

	transform.position = new Vector3(newX, 0.0f, 0.0f);

    }
}
