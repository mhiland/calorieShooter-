using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MockSpwn: MonoBehaviour {

	[Range(3.0f, 30.0f)]
	public float radius;
	public GameObject apple, bread, broccoli, cake, cherry, chicken,
	chips, chocolate, chowmein, cinnaroll, coffee, egg, fries, icecream,
	kimchi, milk, pizza, potato, salad, sandwich, sushi, food;

	float setRadius;
	Vector3 p;
	float time;

    public static int calVal;
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

			int r = Random.Range (0,21);
            //int r = 1;

            if (r == 0) { food = apple; calVal = 52; }
            else if (r == 1) { food = bread; calVal = 274; }
            else if (r == 2) { food = broccoli; calVal = 34; }
           // else if (r == 3) { food = cake; calVal = 0; }
            else if (r == 3) { food = broccoli; calVal = 34; }
            else if (r == 4) { food = cherry; calVal = 50; }
            else if (r == 5) { food = chicken; calVal = 219; }
            else if (r == 6) { food = chips; calVal = 536; }
            else if (r == 7) { food = chocolate; calVal = 546; }
            else if (r == 8) { food = chowmein; calVal = 459; }
         //   else if (r == 9) { food = cinnaroll; calVal = 0; }
            else if (r == 9) { food = chowmein; calVal = 459; }
            else if (r == 10) { food = coffee; calVal = 0; }
            else if (r == 11) { food = egg; calVal = 155; }
            else if (r == 12) { food = fries; calVal = 312; }
            else if (r == 13) { food = icecream; calVal = 207; }
         //   else if (r == 14) { food = kimchi; calVal = 0; }
            else if (r == 14) { food = icecream; calVal = 207; }
            else if (r == 15) { food = milk; calVal = 42; }
            else if (r == 16) { food = pizza; calVal = 266; }
            else if (r == 17) { food = potato; calVal = 77; }
         //   else if (r == 18) { food = salad; calVal = 0; }
            else if (r == 18) { food = potato; calVal = 77; }
            else if (r == 19) { food = sandwich; calVal = 295; }
            //else if (r == 20) { food = sushi; calVal = 0; }
            else if (r == 20) { food = sandwich; calVal = 295; }

            float _rand = Random.Range (0f, 360f);
			Debug.Log ("random number : " + _rand);

			float x = setRadius * Mathf.Cos (_rand) + p.x;
			float z = setRadius * Mathf.Sin (_rand) + p.z;
		
			GameObject _food = (GameObject) Instantiate (food, new Vector3 (x, 0.7f, z), Quaternion.identity);
            //added for being a pointer to store calVal;
            _food.AddComponent<Text>().text=calVal.ToString();
            //added for grouping all the food
            //GameObject foodTag = new GameObject("foodTag");
            //foodTag.transform.parent = _food.transform;
            //added for hiding the text
          //  _food.transform.FindChild("Text").gameObject.SetActive(false);


			Canvas can = _food.GetComponentInChildren<Canvas>();
			Camera cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
			can.worldCamera = cam;

			time = 0;
		}

		

	
	}
}
