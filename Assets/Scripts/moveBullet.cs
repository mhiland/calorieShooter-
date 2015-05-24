using UnityEngine;
using System.Collections;

public class moveBullet : MonoBehaviour {
	public GameObject player1;
    public float speed = 60.0f;
	public Quaternion pos;
    public int up = 180;
    public int down = 0;
    public int left = 90;
    public int right = 270;
    public Vector3 posVec;


    // Use this for initialization
    void Start () {
		pos = GameObject.Find("SpawnPoint").transform.rotation;
        posVec = Input.mousePosition;
       posVec.z = transform.position.z - Camera.main.transform.position.z;
     //   posVec.x = transform.position.x - Camera.main.transform.position.x;
        posVec = Camera.main.ScreenToWorldPoint(posVec);
        posVec.y =transform.position.y;
        
    }

	// Update is called once per frame
	void Update () {
        
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x+posVec.x, transform.position.y, transform.position.z+posVec.z), speed * Time.deltaTime);


        /*
        //transform.Translate(new Vector3(pos.w* speed * Time.deltaTime,  pos.y* speed * Time.deltaTime, pos.z* speed * Time.deltaTime));
        int val = (int)pos.eulerAngles.z;
        if (val == up)
        {
            transform.Translate(new Vector3(0, 0, 1));
        }
        else if (val == down)
        {
            transform.Translate(new Vector3(0, 0, -1));
        }
        else if(val == left)
        {
            transform.Translate(new Vector3(0, 1, 0));
        }
        else
        {
            transform.Translate(new Vector3(0, 1, 0));
        }
        */
    }
}
