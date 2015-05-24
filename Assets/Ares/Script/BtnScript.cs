using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BtnScript : MonoBehaviour {



    int highestCalValueInItems;
    Button lowValBtn;
    Button midValBtn;
    Button highValBtn;
    Button currentBtnSelected;

    struct valueScope {
      public  int minValue;
      public  int maxValue;
    }

    valueScope lowValBtnScope;
    valueScope midValBtnScope;
    valueScope highValBtnScope;
    valueScope currentValScope;
    string debugInfo;

    enum levelOfBtnSelected {
        low=1,
        mid=2,
        high=3

    }
    levelOfBtnSelected currentWeaponLevel;

    Color colorForSelectedBtn;
    Color colorForUnselectedBtn;
    // Use this for initialization
    void Start () {
        highestCalValueInItems = 536;

        lowValBtn = GameObject.Find("LowValButton").GetComponent<Button>();
        midValBtn = GameObject.Find("MidValButton").GetComponent<Button>();
        highValBtn = GameObject.Find("HighValButton").GetComponent<Button>();

        //set defult value for weapon selected
        currentWeaponLevel = levelOfBtnSelected.low;

        // create instance for the scope
        lowValBtnScope = new valueScope();
         midValBtnScope = new valueScope();
         highValBtnScope = new valueScope();

        //assign values to the scope behind each button
        lowValBtnScope.minValue = 0;
        lowValBtnScope.maxValue = (int)(highestCalValueInItems / 3);

        midValBtnScope.minValue = lowValBtnScope.maxValue;
        midValBtnScope.maxValue = (int)(highestCalValueInItems * 2 / 3);

        highValBtnScope.minValue = midValBtnScope.maxValue;
        highValBtnScope.maxValue = highestCalValueInItems;


        lowValBtn.GetComponentInChildren<Text>().text = lowValBtnScope.minValue+ "-" + lowValBtnScope.maxValue;
        midValBtn.GetComponentInChildren<Text>().text = midValBtnScope.minValue + "-" + midValBtnScope.maxValue;
        highValBtn.GetComponentInChildren<Text>().text = highValBtnScope.minValue + "-" + highValBtnScope.maxValue;

        //initialize for the colors of butttons
         colorForSelectedBtn = Color.red;
         colorForUnselectedBtn = Color.white;
    }
	
	// Update is called once per frame
	void Update () {

        keyboardInput();

        switch (currentWeaponLevel)
        {
            case levelOfBtnSelected.low:
                lowValBtn.image.color =colorForSelectedBtn;
                midValBtn.image.color = colorForUnselectedBtn;
                highValBtn.image.color = colorForUnselectedBtn;
                break;
            case levelOfBtnSelected.mid:
                lowValBtn.image.color = colorForUnselectedBtn;
                midValBtn.image.color = colorForSelectedBtn;
                highValBtn.image.color = colorForUnselectedBtn;
                break;
            case levelOfBtnSelected.high:
                lowValBtn.image.color = colorForUnselectedBtn;
                midValBtn.image.color = colorForUnselectedBtn;
                highValBtn.image.color = colorForSelectedBtn;
                break;
            default:
       //         lowValBtn.image.color = Color.red;
                break;
        }



    }

    public void lowValBtnFunc() {
        currentBtnSelected = lowValBtn;
        currentValScope = lowValBtnScope;
        currentWeaponLevel = levelOfBtnSelected.low;

        debugInfo = "the highest cal value: " + highestCalValueInItems + "\nthe scope chosen: " + currentValScope.minValue + " to " + currentValScope.maxValue;
       // GameObject.Find("DebugText").GetComponent<Text>().text = debugInfo;
    }

    public void midValBtnFunc()
    {
        currentBtnSelected = midValBtn;
        currentWeaponLevel = levelOfBtnSelected.mid;
        currentValScope = midValBtnScope;

        debugInfo = "the highest cal value: " + highestCalValueInItems + "\nthe scope chosen: " + currentValScope.minValue + " to " + currentValScope.maxValue;
       // GameObject.Find("DebugText").GetComponent<Text>().text = debugInfo;
    }

    public void highValBtnFunc()
    {
        currentBtnSelected = highValBtn;
        currentWeaponLevel = levelOfBtnSelected.high;
        currentValScope = highValBtnScope;

        debugInfo = "the highest cal value: "+highestCalValueInItems+"\nthe scope chosen: " + currentValScope.minValue + " to " + currentValScope.maxValue;
      //  GameObject.Find("DebugText").GetComponent<Text>().text = debugInfo;
    }

    void keyboardInput() {

        if (Input.GetKeyDown("1"))
        {
            lowValBtnFunc();
        }

        else if (Input.GetKeyDown("2")) {
            midValBtnFunc();
        }

        else if (Input.GetKeyDown("3"))
        {
            highValBtnFunc();
        }

    }


}

