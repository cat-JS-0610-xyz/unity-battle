using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightgaming : MonoBehaviour
{
	public Rigidbody2D playerRB;
	public Animator anim;
	float moveForce = 10f;
	float jumpForce = 350f;
	public bool isjumped = false;
	public SpriteRenderer r;
	private bool facingRight = true;
	float moveInput;
	//public int islol = 0;
	//Random rnd = new Random(245);

	// Start is called before the first frame update
	void Start()
    {
		void Start()
		{
			anim = GetComponent<Animator>();
			r = GetComponent<SpriteRenderer>();
		}
	}
	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.D))
		{
			playerRB.AddForce(Vector2.right * moveForce);
			r.flipX = false;
		}
		if (Input.GetKey(KeyCode.A))
		{
			playerRB.AddForce(Vector2.left * moveForce);
			r.flipX = true;
		}
	}
	// Update is called once per frame
	void Update()
    {
		moveInput = Input.GetAxis("Horizontal");

		if (moveInput < 0 && facingRight)
		{
			Flip();
		}
		if (moveInput > 0 && !facingRight)
		{
			Flip();
		}


		if (Input.GetKeyDown(KeyCode.W) && isjumped == false)
		{
			playerRB.AddForce(Vector2.up * jumpForce);
			isjumped = true;
		}
		if (isjumped) {
			anim.SetBool("jump", true);
		} else {
			anim.SetBool("jump", false);
		}
		anim.SetFloat("moveX", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
		//islol = random(0,50);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.layer == LayerMask.NameToLayer("earth"))
		{
			isjumped = false;
		}
	}

	private void Flip()
	{
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;


	}
}
