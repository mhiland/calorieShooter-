using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FollowingText : MonoBehaviour {

	  Text _text;
    int currentCalVal;
	// Use this for initialization
	void Start () {
		_text = GetComponent<Text> ();
		_text.color = Color.black;
        _text.fontSize = 20;
		if (this.gameObject.tag == "Applejuice")
			_text.text = "Cal: "+MockSpwn.calVal;
		else if (this.gameObject.tag == "bread")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "broccoli")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "cake")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "cherry")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "chicken")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "chips")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "chocolate")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "chowmein")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "cinnaroll")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "coffee")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "egg")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "fries")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "icecream")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "kimchi")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "milk")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "pizza")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "potato")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "salad")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "sandwich")
            _text.text = "Cal: " + MockSpwn.calVal;
        else if (this.gameObject.tag == "sushi")
            _text.text = "Cal: " + MockSpwn.calVal;

        currentCalVal = MockSpwn.calVal;
    }
	
	// Update is called once per frame
	void Update () {

        //this.transform.position = new Vector3 (_parent.transform.position.x + xOffset, _parent.transform.position.y + yOffset, _parent.transform.position.z);

        if (powerUpEffects.isDisplayEnabled)
        {
            _text.text = "Cal: " + currentCalVal;
        }
        else {
            _text.text = "";
        }

      
    }
}
