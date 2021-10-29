using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float Speed = 1.0f;
	
	private Rigidbody Physics;

    // Start is called before the first frame update
    void Start()
    {
        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento
        float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical"); 
		
		transform.Translate(new Vector3 (horizontal, 0.0f, vertical) * Time.deltaTime * Speed);
		   
    }
}
