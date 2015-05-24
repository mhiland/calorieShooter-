using UnityEngine;
using System.Collections;

public class powerUpSelector : MonoBehaviour {

    enum powerUpItemTypes {
        displayCalVal,
        speedUp,
    }
    float randomVal;
    powerUpItemTypes powerUpType;

	// Use this for initialization
	void Start () {
        randomVal = Random.value;
        
        if (randomVal >= 0.5)
        {
            powerUpType = powerUpItemTypes.displayCalVal;
            // gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.blue;
            gameObject.GetComponent<MeshRenderer>().materials[0].mainTexture= Resources.Load("glasses") as Texture2D;
        }
        else {
            powerUpType = powerUpItemTypes.speedUp;
            //gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.green;
            gameObject.GetComponent<MeshRenderer>().materials[0].mainTexture = Resources.Load("Shoes") as Texture2D;
        }



	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player1")
        {
            if (powerUpType == powerUpItemTypes.speedUp)
            {
                powerUpEffects.isSpeedUpTrigered = true;
                Debug.Log("speedUp");
            }
            else if (powerUpType == powerUpItemTypes.displayCalVal) {
                powerUpEffects.isCalValDisplayTrigered = true;
                Debug.Log("Displayed");
            }
            Destroy(this.gameObject);
        }

    }

}
