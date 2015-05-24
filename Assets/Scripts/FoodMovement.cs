using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FoodMovement : MonoBehaviour {

	GameObject player1;
	[Range(0.1f, 3f)]
	public float speed;
    AudioSource eatingsound;





    // Use this for initialization
    void Start () {
        eatingsound = this.GetComponent<AudioSource>();
        Debug.Log ("Object created");
		//this.transform.position = new Vector3 (player1.transform.position.x + 500, player1.transform.position.y + 500, player1.transform.position.z);
		player1 = GameObject.FindWithTag("player1");
		if (player1 != null)
			Debug.Log ("found player1!");
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (Mathf.Abs ((player1.transform.position - this.transform.position).magnitude) > .5f) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, player1.transform.position + 23*Vector3.left, speed);
			//float x = Mathf.Lerp(this.transform.position.x, player1.transform.position.x, Time.deltaTime * speed);
			//float z = Mathf.Lerp(this.transform.position.z, player1.transform.position.z, Time.deltaTime * speed);
			//this.transform.position = new Vector3(x,this.transform.position.y,z);
		//}
	
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "player1") {
            
            Debug.Log ("contacted");
            HPBarScript.hpBarImage.fillAmount -= 0.1f;
            //eatingsound.Play();
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Bullet")
        {

            string example = this.gameObject.GetComponent<Text>().text;

            int calVal = int.Parse(example);
            Debug.Log("calVal:" + calVal + "min: " + BtnScript.currentValScope.minValue + "max: " + BtnScript.currentValScope.maxValue);
            if ((calVal >= BtnScript.currentValScope.minValue) && (calVal <= BtnScript.currentValScope.maxValue))
            {

                Destroy(this.gameObject);
            }

            Destroy(other.gameObject);

        }

    }
}
