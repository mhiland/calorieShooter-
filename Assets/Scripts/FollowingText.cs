using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FollowingText : MonoBehaviour {

	public GameObject _parent;
	Text _text;

	[Range(-100f, 100f)]
	public float xOffset;
	[Range(-100f, 100f)]
	public float yOffset;

	// Use this for initialization
	void Start () {
		//this.transform.position = _parent.transform.position + Vector3.up;
		_text = GetComponent<Text> ();
		_text.text = "HELLO!";
	
	}
	
	// Update is called once per frame
	void Update () {

		//this.transform.position = new Vector3 (_parent.transform.position.x + xOffset, _parent.transform.position.y + yOffset, _parent.transform.position.z);

	
	}
}
