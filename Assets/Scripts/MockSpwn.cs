using UnityEngine;
using System.Collections;

public class MockSpwn: MonoBehaviour {

	[Range(3.0f, 30.0f)]
	public float radius;
	public GameObject apple, bread, broccoli, cake, cherry, chicken,
	chips, chocolate, chowmein, cinnaroll, coffee, egg, fries, icecream,
	kimchi, milk, pizza, potato, salad, sandwich, sushi, food;

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

			//int r = Random.Range (0,21);
			int r = 1;

			if(r == 0) food = apple;
			else if(r == 1) food = bread;
			else if(r == 2) food = broccoli;
			else if(r == 3) food = cake;
			else if(r == 4) food = cherry;
			else if(r == 5) food = chicken;
			else if(r == 6) food = chips;
			else if(r == 7) food = chocolate;
			else if(r == 8) food = chowmein;
			else if(r == 9) food = cinnaroll;
			else if(r == 10) food = coffee;
			else if(r == 11) food = egg;
			else if(r == 12) food = fries;
			else if(r == 13) food = icecream;
			else if(r == 14) food = kimchi;
			else if(r == 15) food = milk;
			else if(r == 16) food = pizza;
			else if(r == 17) food = potato;
			else if(r == 18) food = salad;
			else if(r == 19) food = sandwich;
			else if(r == 20) food = sushi;

			float _rand = Random.Range (0f, 360f);
			Debug.Log ("random number : " + _rand);

			float x = setRadius * Mathf.Cos (_rand) + p.x;
			float z = setRadius * Mathf.Sin (_rand) + p.z;
		
			GameObject _food = (GameObject) Instantiate (food, new Vector3 (x, 0.2f, z), Quaternion.identity);
			Canvas can = _food.GetComponentInChildren<Canvas>();
			Camera cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
			can.worldCamera = cam;

			time = 0;
		}

		

	
	}
}
