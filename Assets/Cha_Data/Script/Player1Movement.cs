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
		if (Input.GetKey(KeyCode.A) && gameObject.transform.position.x > GameObject.Find("Wall3").transform.position.x)
		{
			Vector3 position = this.transform.position;
			position.x-=movingSpeed;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(180, 90, 90);
			animator = GetComponent<Animator>();
			//animator.SetBool("isMoving", true);


		}
		if (Input.GetKey(KeyCode.D) && gameObject.transform.position.x < GameObject.Find("Wall4").transform.position.x)
		{
			Vector3 position = this.transform.position;
			position.x+=movingSpeed;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(0, 90, 90);
		//	this.transform.Rotate(0, 0, 90);
		}
		if (Input.GetKey(KeyCode.W) && gameObject.transform.position.z < GameObject.Find("Wall2").transform.position.z)
		{
			Vector3 position = this.transform.position;
			position.z+=movingSpeed; 
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(90, 90, 90);
		}
		if (Input.GetKey(KeyCode.S) && gameObject.transform.position.z > GameObject.Find("Wall1").transform.position.z)
		{
			Vector3 position = this.transform.position;
			position.z-=movingSpeed;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(270, 90, 90);
		}
	}
}
