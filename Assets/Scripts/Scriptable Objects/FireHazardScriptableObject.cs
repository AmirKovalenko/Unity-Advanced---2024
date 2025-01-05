using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FireHazard",
    menuName = "Scriptable Objects/FireHazard", order = 0)]
public class FireHazardScriptableObject : ScriptableObject
{
    [SerializeField] private int minDMG;
    [SerializeField] private int maxDMG;

    public int GetRandomFireDamage()
    {
        int randomDamage = UnityEngine.Random.Range(minDMG, maxDMG + 1);
        Debug.Log(randomDamage + " Fire DMG");
        return randomDamage;
    }

}
