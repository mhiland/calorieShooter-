using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FollowingText : MonoBehaviour {

	Text _text;

	// Use this for initialization
	void Start () {
		_text = GetComponent<Text> ();
		_text.color = Color.white;
		if (this.gameObject.tag == "Applejuice")
			_text.text = "AppleJuice";
		else if (this.gameObject.tag == "bread")
			_text.text = "Bread";
		else if (this.gameObject.tag == "broccoli")
			_text.text = "Broccoli";
		else if (this.gameObject.tag == "cake")
			_text.text = "Cake";
		else if (this.gameObject.tag == "cherry")
			_text.text = "Cherry";
		else if (this.gameObject.tag == "chicken")
			_text.text = "Chicken";
		else if (this.gameObject.tag == "chips")
			_text.text = "Chips";
		else if (this.gameObject.tag == "chocolate")
			_text.text = "Chocolate";
		else if (this.gameObject.tag == "chowmein")
			_text.text = "Chowmein";
		else if (this.gameObject.tag == "cinnaroll")
			_text.text = "Cinnamon Roll";
		else if (this.gameObject.tag == "coffee")
			_text.text = "Coffee";
		else if (this.gameObject.tag == "egg")
			_text.text = "Fried Egg";
		else if (this.gameObject.tag == "fries")
			_text.text = "French Fries";
		else if (this.gameObject.tag == "icecream")
			_text.text = "Icecream";
		else if (this.gameObject.tag == "kimchi")
			_text.text = "Kimchi";
		else if (this.gameObject.tag == "milk")
			_text.text = "Milk";
		else if (this.gameObject.tag == "pizza")
			_text.text = "Pizza";
		else if (this.gameObject.tag == "potato")
			_text.text = "Potato";
		else if (this.gameObject.tag == "salad")
			_text.text = "Salad";
		else if (this.gameObject.tag == "sandwich")
			_text.text = "Sandwich";
		else if (this.gameObject.tag == "sushi")
			_text.text = "Sushi";
	}
	
	// Update is called once per frame
	void Update () {

		//this.transform.position = new Vector3 (_parent.transform.position.x + xOffset, _parent.transform.position.y + yOffset, _parent.transform.position.z);

	
	}
}
