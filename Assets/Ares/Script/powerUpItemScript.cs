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

        if (timer > 3)
        {

            float _randX = Random.Range(-78, 76);
            float _randY = Random.Range(-75, 60);
            //Debug.Log("random number : " + _rand);

            float x = _randX;

            float y =_randY;

            Instantiate(powerUpItem, new Vector3(x, 1, y), Quaternion.identity);

            timer = 0;
        }
    }



}
