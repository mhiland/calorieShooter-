using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FoodMovement : MonoBehaviour {

	GameObject player1;
	[Range(0.1f, 3f)]
	public float speed;





	// Use this for initialization
	void Start () {
		Debug.Log ("Object created");
		//this.transform.position = new Vector3 (player1.transform.position.x + 500, player1.transform.position.y + 500, player1.transform.position.z);
		player1 = GameObject.FindWithTag("player1");
		if (player1 != null)
			Debug.Log ("found player1!");
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs ((this.transform.position - player1.transform.position).magnitude) > 5f) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, player1.transform.position, speed);
		}
	
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "player1") {
			Debug.Log ("contacted");
			Destroy(this.gameObject);
		}

	}
}
