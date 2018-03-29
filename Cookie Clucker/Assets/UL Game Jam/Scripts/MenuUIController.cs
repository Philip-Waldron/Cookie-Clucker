using System.Collections;
using System.Collections.Generic;
using Leap.Unity.Interaction;
using UnityEngine;

public class MenuUIController : MonoBehaviour {

    public GameObject GameManager;
    public int activationThreshold = 100;
    private int cookieCount;
    public GameObject activeMenu;


    void Start()
    {
        //GameManager = GameObject.Find("GameManager");
    }

    void Update () {
        if (GetComponentInChildren<TippyBirdUpgradeCost>() != null)
        {
            activationThreshold = GetComponentInChildren<TippyBirdUpgradeCost>().cost;
        }
        else if (GetComponentInChildren<LilOvenUpgradeCost>() != null)
        {
            activationThreshold = GetComponentInChildren<LilOvenUpgradeCost>().cost;
        }
        else if (GetComponentInChildren<ChickenConscriptUpgradeCost>() != null)
        {
            activationThreshold = GetComponentInChildren<ChickenConscriptUpgradeCost>().cost;
        }

        cookieCount = GameManager.GetComponent<GameManager>().GetCookieWallet();

        if (cookieCount >= activationThreshold)
        {
            gameObject.GetComponent<InteractionBehaviour>().ignoreContact = false;
            activeMenu.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<InteractionBehaviour>().ignoreContact = true;
            activeMenu.SetActive(false);
        }
	}
}
