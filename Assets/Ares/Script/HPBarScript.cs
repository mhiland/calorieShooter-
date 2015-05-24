using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPBarScript : MonoBehaviour {
public static Image hpBarImage;


	// Use this for initialization
	void Start () {
        hpBarImage = GameObject.Find("HP Bar_Full").GetComponent<Image>();

        hpBarImage.fillAmount = 1;
	}
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetKey("space")&&!isHPBarDecreased)
        //{
        //    hpBarImage.fillAmount -= 0.1f;
        //    isHPBarDecreased=true;
        //}
        
	}



    //void healthBarDecrease(float decreasingPercentage, float decreasingSpeed)
    //{

    //    hpBarImage.fillAmount -= 0.1f * Time.deltaTime;
    //}
}
