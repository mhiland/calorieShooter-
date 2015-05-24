using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class powerUpEffects : MonoBehaviour {
   public static bool isCalValDisplayTrigered;
   public static bool isSpeedUpTrigered;
    float powerUpTime;
    float maxPowerUpTime=5;
    bool isDisplayEnabled;

	// Use this for initialization
	void Start () {
        //foreach (GameObject g in GameObject.FindGameObjectsWithTag("food"))
        //{
        //    //  g.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>().text = "1111111";
        //    g.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>().enabled = false;
        //}
    }
	
	// Update is called once per frame
	void Update () {

        if (isCalValDisplayTrigered)
        {
            //for turning on the display
            if (powerUpTime < maxPowerUpTime *60 )
            {
                powerUpTime += 1;
                if (!isDisplayEnabled)
                {
                    //foreach (GameObject g in GameObject.FindGameObjectsWithTag("food"))
                    //{
                    //    //  g.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>().text = "1111111";
                    //    g.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>().enabled = true;
                    //}
                    isDisplayEnabled = true;
                }
                
            }
            else {
                //for turning off the display
                if (isDisplayEnabled)
                {
                    //foreach (GameObject g in GameObject.FindGameObjectsWithTag("food"))
                    //{
                    //    g.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>().enabled = true;
                    //}
                    isDisplayEnabled = false;
                }
                powerUpTime = 0;
                Debug.Log("display ended");
                isCalValDisplayTrigered = false;
            }
            
            
        }

        if (isSpeedUpTrigered)
        {



            isSpeedUpTrigered = false;
        }
	}
}
