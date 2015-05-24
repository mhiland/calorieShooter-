using UnityEngine;
using System.Collections;

public class MockController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up"))
			this.transform.position += Vector3.up * 3;
			
		if (Input.GetKey ("down"))
			this.transform.position += Vector3.down * 3;

		if (Input.GetKey ("left"))
			this.transform.position += Vector3.left * 3;

		if (Input.GetKey ("right"))
			this.transform.position += Vector3.right * 3;
	
	}
}
