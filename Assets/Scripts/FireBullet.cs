using UnityEngine;
using System.Collections;

public class FireBullet : MonoBehaviour {


	public GameObject Bullet;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			var pos = GameObject.Find("SpawnPoint").transform;	
			Instantiate(Bullet, pos.position, pos.rotation);
		}

        if (Input.GetMouseButtonDown(0))
        {
            var pos = GameObject.Find("SpawnPoint").transform;
            Instantiate(Bullet, pos.position, pos.rotation);
        }
        Destroy(GameObject.Find("Bullet(Clone)"), 5);
    }
}
