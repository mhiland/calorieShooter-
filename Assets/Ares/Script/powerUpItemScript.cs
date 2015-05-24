using UnityEngine;
using System.Collections;

public class powerUpItemScript : MonoBehaviour {
    public GameObject powerUpItem;

    float timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if (timer > 15)
        {

            float _randX = Random.Range(-60, 70);
            float _randY = Random.Range(-30, 15);
            //Debug.Log("random number : " + _rand);

            float x = _randX;

            float y =_randY;

            Instantiate(powerUpItem, new Vector3(x, 1, y), Quaternion.Euler(90,0,0));

            timer = 0;
        }
    }



}
