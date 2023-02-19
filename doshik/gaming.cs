using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaming : MonoBehaviour
{
	public Rigidbody2D playerRB;
	public SpriteRenderer playerR;
	public bool isjumped = false;
	public float inputX;
	float moveForce = 1f;
	float jumpForce = 350f;
	// Start is called before the first frame update
	void Start()
	{

	}
	// Update is called once per frame
	void FixedUpdate()
	{
	}
	void Update()
    {
		if (Input.GetKey(KeyCode.D))
		{
			playerRB.AddForce(Vector2.right * moveForce);
			//playerRB.MovePosition(playerRB.position + new Vector2(0.05f, 0f));
			playerR.flipX = false;
		}
		if (Input.GetKey(KeyCode.A))
		{
			playerRB.AddForce(Vector2.left * moveForce);
			//playerRB.MovePosition(playerRB.position + new Vector2(-0.05f, 0f));
			playerR.flipX = true;
		}
		inputX = Input.GetAxis("Horizontal");
		if (Input.GetKeyDown(KeyCode.W))//&& isjumped == false
		{
			playerRB.AddForce(Vector2.up * jumpForce);
			//isjumped = true;
		}
	}
}