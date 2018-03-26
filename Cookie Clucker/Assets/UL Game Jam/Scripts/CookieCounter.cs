using UnityEngine;
using System.Collections;
using TMPro;

public class CookieCounter : MonoBehaviour
{
    private int _cookieCount;
    private int _cookieWallet;
    public GameObject GameManager;

    void Update()
    {
        _cookieWallet = GameManager.GetComponent<GameManager>().GetCookieWallet();
        _cookieCount = GameManager.GetComponent<GameManager>().GetCookiesToDate();
    }

    void LateUpdate()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText("You have accumulated about {0} cookies, well done - you can only spend like {1} though...", _cookieCount, _cookieWallet);
    }
}