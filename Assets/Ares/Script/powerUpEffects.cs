using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class powerUpEffects : MonoBehaviour {
   public static bool isCalValDisplayTrigered;
   public static bool isSpeedUpTrigered;
    float powerUpTimeForDisplay;
    float powerUpTimeForSpeedUp;
    float maxPowerUpTime=5;
   public static bool isDisplayEnabled;
    public static bool isSpeedUpEnabled;

	// Use this for initialization
	void Start () {


    }
	
	// Update is called once per frame
	void Update () {

        if (isCalValDisplayTrigered)
        {
            //for turning on the display
            if (powerUpTimeForDisplay < maxPowerUpTime * 60)
            {
                powerUpTimeForDisplay += 1;
                if (!isDisplayEnabled)
                {

                    isDisplayEnabled = true;
                }

            }
            else
            {
                //for turning off the display
                if (isDisplayEnabled)
                {

                    isDisplayEnabled = false;
                }
                powerUpTimeForDisplay = 0;
                Debug.Log("display ended");
                isCalValDisplayTrigered = false;
            }


        }
     

        if (isSpeedUpTrigered)
        {

            //for turning on the speedUp
            if (powerUpTimeForSpeedUp < maxPowerUpTime * 60)
            {
                powerUpTimeForSpeedUp += 1;
                if (!isSpeedUpEnabled)
                {

                    isSpeedUpEnabled = true;
                    Player1Movement.movingSpeed = 2;
                }

            }
            else
            {
                //for turning off the speedup
                if (isSpeedUpEnabled)
                {
                    Player1Movement.movingSpeed = 1;
                    isSpeedUpEnabled = false;
                }
                powerUpTimeForSpeedUp = 0;
            
                isSpeedUpTrigered = false;
            }

           
        }
	}
}
