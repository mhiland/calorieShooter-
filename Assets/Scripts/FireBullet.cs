using UnityEngine;
using System.Collections;

public class FireBullet : MonoBehaviour {


	public GameObject Bullet;
    AudioSource bulletSound;
    Animation bulletaction;


    // Use this for initialization
    void Start () {
        bulletSound = this.GetComponent<AudioSource>();
        bulletaction = this.GetComponent<Animation>();
    }
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			var pos = GameObject.Find("SpawnPoint").transform;	
			Instantiate(Bullet, pos.position, pos.rotation);
            
            bulletSound.Play();
            bulletaction.Play();
            
        }

        if (Input.GetMouseButtonDown(0))
        {
            var pos = GameObject.Find("SpawnPoint").transform;
            Instantiate(Bullet, pos.position + new Vector3(0,0.7f,0), pos.rotation);
           
            bulletSound.Play();
         //   bulletaction.Play();
            
        }
    }

    
}
