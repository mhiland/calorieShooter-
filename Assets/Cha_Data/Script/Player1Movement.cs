using UnityEngine;
using System.Collections;

public class Player1Movement : MonoBehaviour {
  public static  float movingSpeed = 1;
    AudioSource walkingsound;
    Animation walking;

    // Use this for initialization
    void Start () {
        walkingsound = this.GetComponent<AudioSource>();
        walking = this.GetComponent<Animation>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x -= movingSpeed;
            this.transform.position = position;
            this.transform.rotation = Quaternion.Euler(180, 90, 90);

            if (!walkingsound.isPlaying)
            {
                walkingsound.Play();
                walking.Play();
            }

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x += movingSpeed;
            this.transform.position = position;
            this.transform.rotation = Quaternion.Euler(0, 90, 90);
            if (!walkingsound.isPlaying)
            {
                walkingsound.Play();
                walking.Play();
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.z += movingSpeed;
            this.transform.position = position;
            this.transform.rotation = Quaternion.Euler(90, 90, 90);
            if (!walkingsound.isPlaying)
            {
                walkingsound.Play();
                walking.Play();
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.z -= movingSpeed;
            this.transform.position = position;
            this.transform.rotation = Quaternion.Euler(270, 90, 90);
            if (!walkingsound.isPlaying)
            {
                walkingsound.Play();
                walking.Play();
            }
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        { 
            walkingsound.Stop();
            walking.Stop();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            walkingsound.Stop();
            walking.Stop();
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            walkingsound.Stop();
            walking.Stop();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            walkingsound.Stop();
            walking.Stop();
        }
        if (Input.GetMouseButtonDown(0))
        {

            walking.CrossFade("Attack");

        }
    }
}
