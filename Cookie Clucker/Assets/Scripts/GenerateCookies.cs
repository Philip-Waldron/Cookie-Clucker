using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCookies : MonoBehaviour
{
	public GameManager GameManager;
	public int CookiesPerSecond;

	void Start()
	{
		GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		if (CookiesPerSecond > 0)
		{
			StartCoroutine(MakeCookies());
		}
	}
	
	IEnumerator MakeCookies()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			GameManager.UpdateCookieCount(CookiesPerSecond);
		}
	}
}
