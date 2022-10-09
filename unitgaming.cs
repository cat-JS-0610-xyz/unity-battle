using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class unitgaming : MonoBehaviour
{
	public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.D))
		{
			player.MovePosition(player.position + new Vector2(1f,0f));
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			player.MovePosition(player.position + new Vector2(-1f, 0f));
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			player.MovePosition(player.position + new Vector2(0f, 1f));
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			player.MovePosition(player.position + new Vector2(0f, -1f));
		}
	}
}
