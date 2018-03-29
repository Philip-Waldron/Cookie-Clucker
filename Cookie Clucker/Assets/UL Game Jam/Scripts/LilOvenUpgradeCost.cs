﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LilOvenUpgradeCost : MonoBehaviour
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
			textmeshPro.SetText("CHRIST I NEED AN OVEN\nThat'll be like {0} cookies, dude", cost);
		}
		else
		{
			textmeshPro.SetText("CHRIST I NEED AN OVEN\nThat'll be like {0} cookies, dude", initalCost);
		}
	}
}
