using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalletSpend : MonoBehaviour
{
	private int cost = 100;
	public GameManager gameManager;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponentInChildren<TippyBirdUpgradeCost>() != null)
		{
			cost = GetComponentInChildren<TippyBirdUpgradeCost>().cost;
		}
		else if (GetComponentInChildren<LilOvenUpgradeCost>() != null)
		{
			cost = GetComponentInChildren<LilOvenUpgradeCost>().cost;
		}
		else if (GetComponentInChildren<ChickenConscriptUpgradeCost>() != null)
		{
			cost = GetComponentInChildren<ChickenConscriptUpgradeCost>().cost;
		}
		else
		{
			cost = 100;
		}
	}

	public void SpendCookies()
	{
		if (gameManager.GetCookieWallet() >= cost)
		{
			gameManager.SpendCookies(cost);
		}
	}
}
