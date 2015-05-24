using UnityEngine;
using System.Collections;

public class Player1Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	
	void Update ()
	{
		Animator animator;
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Vector3 position = this.transform.position;
			position.x--;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(180, 90, 90);
			animator = GetComponent<Animator>();
			animator.SetBool("isMoving", true);


		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(0, 90, 90);
		//	this.transform.Rotate(0, 0, 90);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			Vector3 position = this.transform.position;
			position.z++; 
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(90, 90, 90);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			Vector3 position = this.transform.position;
			position.z--;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(270, 90, 90);
		}
	}
}
