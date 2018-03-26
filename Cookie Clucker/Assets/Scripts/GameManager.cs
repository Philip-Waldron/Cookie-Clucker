using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private int CookieWallet;
	private int CookiesToDate;
	
	void Start () {
		
	}
	
	void Update () {
		
	}

	public void UpdateCookieCount(int addNum)
	{
		CookieWallet = CookieWallet + addNum;
		CookiesToDate = CookiesToDate + addNum;
	}

	public void SpendCookies(int subNum)
	{
		CookieWallet = CookieWallet - subNum;
	}

	public int GetCookieWallet()
	{
		return CookieWallet;
	}
	
	public int GetCookiesToDate()
	{
		return CookiesToDate;
	}
}
