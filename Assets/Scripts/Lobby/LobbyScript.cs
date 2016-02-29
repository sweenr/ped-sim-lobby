using UnityEngine;
using System.Collections;

public class LobbyScript : MonoBehaviour {

    public GameObject targetOne;
    public GameObject targetTwo;

    private bool targetOneFadedOut = true;
    private bool targetTwoFadedOut = true;

	// Use this for initialization
	void Start () {

        if (targetOne != null && targetTwo != null)
        {
            FadeInOut fade = (FadeInOut)targetOne.GetComponent(typeof(FadeInOut));
            fade.FadeOut(0.1f);
            FadeInOut fade2 = (FadeInOut)targetTwo.GetComponent(typeof(FadeInOut));
            fade2.FadeOut(0.1f);
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Alpha1) == true && targetOneFadedOut)
        {
            FadeInOut fade = (FadeInOut)targetOne.GetComponent(typeof(FadeInOut));
            fade.FadeIn();
            targetOneFadedOut = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FadeInOut fade = (FadeInOut)targetOne.GetComponent(typeof(FadeInOut));
            fade.FadeOut();
            targetOneFadedOut = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) == true && targetTwoFadedOut)
        {
            FadeInOut fade = (FadeInOut)targetTwo.GetComponent(typeof(FadeInOut));
            fade.FadeIn();
            targetTwoFadedOut = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FadeInOut fade = (FadeInOut)targetTwo.GetComponent(typeof(FadeInOut));
            fade.FadeOut();
            targetTwoFadedOut = true;
        }


	}  
}
