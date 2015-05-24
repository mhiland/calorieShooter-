using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Player1Movement : MonoBehaviour {
    public static  float movingSpeed = 1;
    public static Image hpBarImage;
    AudioSource walkingsound;
    Animation walking;
    // Use this for initialization
    void Start () {
        walkingsound = this.GetComponent<AudioSource>();
        walking = this.GetComponent<Animation>();
        hpBarImage = GameObject.Find("HP Bar_Full").GetComponent<Image>();
    }
	
	
	void Update ()
	{
		
		if (Input.GetKey(KeyCode.A) && gameObject.transform.position.x > GameObject.Find("Wall3").transform.position.x)
		{
			Vector3 position = this.transform.position;
			position.x-=movingSpeed;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(180, 90, 90);

            if (!walkingsound.isPlaying)
            {
                walkingsound.Play();
                walking.Play();
            }


        }
		if (Input.GetKey(KeyCode.D) && gameObject.transform.position.x < GameObject.Find("Wall4").transform.position.x)
		{
			Vector3 position = this.transform.position;
			position.x+=movingSpeed;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(0, 90, 90);
            if (!walkingsound.isPlaying)
            {
                walkingsound.Play();
                walking.Play();
            }
        }
		if (Input.GetKey(KeyCode.W) && gameObject.transform.position.z < GameObject.Find("Wall2").transform.position.z)
		{
			Vector3 position = this.transform.position;
			position.z+=movingSpeed; 
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(90, 90, 90);
            if (!walkingsound.isPlaying)
            {
                walkingsound.Play();
                walking.Play();
            }
        }
		if (Input.GetKey(KeyCode.S) && gameObject.transform.position.z > GameObject.Find("Wall1").transform.position.z)
		{
			Vector3 position = this.transform.position;
			position.z-=movingSpeed;
			this.transform.position = position;
			this.transform.rotation = Quaternion.Euler(270, 90, 90);
            if (!walkingsound.isPlaying)
            {
                walkingsound.Play();
                walking.Play();
            }
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            walkingsound.Stop();
            walking.Stop();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            walkingsound.Stop();
            walking.Stop();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            walkingsound.Stop();
            walking.Stop();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            walkingsound.Stop();
            walking.Stop();
        }
        if (Input.GetMouseButtonDown(0))
        {
            walking.CrossFade("Attack");
        }
        if (hpBarImage.fillAmount <= 0)
        {
            //Game Over
            walking.CrossFade("Dead");
            print("health bar empty");
        }
    }
}
