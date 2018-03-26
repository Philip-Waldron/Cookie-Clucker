using UnityEngine;
using System.Collections;
using TMPro;

public class UpgradeCounter : MonoBehaviour {

    public int upgradeCount;

    void Update()
    {
        
    }

    public void UpdateCounter()
    {
        upgradeCount++;
    }

    void LateUpdate()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText("Cool, you have {0} of these.", upgradeCount);
    }
}
