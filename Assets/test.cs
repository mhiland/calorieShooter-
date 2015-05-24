using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
  // public static bool isGetCollided;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        HPBarScript.hpBarImage.fillAmount -= 0.1f;
        Destroy(col.gameObject);
        
    }
}
