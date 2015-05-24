using UnityEngine;
using System.Collections;

public class Player1Movement : MonoBehaviour {
  public static  float movingSpeed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	
	void Update ()
	{
		Animator animator;
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Vector3 position = this.transform.position;
			position.x-=movingSpeed;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(180, 90, 90);
			animator = GetComponent<Animator>();
			//animator.SetBool("isMoving", true);


		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			Vector3 position = this.transform.position;
			position.x+=movingSpeed;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(0, 90, 90);
		//	this.transform.Rotate(0, 0, 90);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			Vector3 position = this.transform.position;
			position.z+=movingSpeed; 
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(90, 90, 90);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			Vector3 position = this.transform.position;
			position.z-=movingSpeed;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(270, 90, 90);
		}
	}
}
