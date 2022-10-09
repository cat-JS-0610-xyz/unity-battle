using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botgaming : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		for (int steps = 0; steps < 5;steps ++) {
			//transform.position = new Vector3(transform.position.x, transform.position.y - 0.001f, 0);
			transform.position = new Vector3(transform.position.x, transform.position.y, 0);
		}
		Debug.Log("KVOKKA");
		//Debug.Log(Time.DeltaTime);
	}
}
