using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TippyBirdUpgradeCost : MonoBehaviour
{
	public int initalCost;
	public int cost;

	public UpgradeCounter upgradeCount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		cost = initalCost * (upgradeCount.upgradeCount + 1);
	}
	
	void LateUpdate()
	{
		TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
		if (cost != 0)
		{
			textmeshPro.SetText("PLACE TIPPY BOI ORDER That's a {0} cookies.", cost);
		}
		else
		{
			textmeshPro.SetText("PLACE TIPPY BOI ORDER That's a {0} cookies.", initalCost);
		}
	}
}
