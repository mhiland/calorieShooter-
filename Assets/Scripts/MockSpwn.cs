using UnityEngine;
using System.Collections;

public class MockSpwn: MonoBehaviour {

	[Range(3.0f, 30.0f)]
	public float radius;
	public GameObject food;

	float setRadius;
	Vector3 p;
	float time;

	// Use this for initialization
	void Start () {
		time = 0;
		setRadius = Mathf.PI * Mathf.Pow (radius, 2.0f);
		GameObject player = GameObject.FindWithTag ("player1");
		p = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		if (time > 3) {

			float _rand = Random.Range (0f, 360f);
			Debug.Log ("random number : " + _rand);

			float x = setRadius * Mathf.Cos (_rand) + p.x;
			float z = setRadius * Mathf.Sin (_rand) + p.z;
		
			Instantiate (food, new Vector3 (x, 0, z), Quaternion.Euler(90,0,0));

			time = 0;
		}

		

	
	}
}
