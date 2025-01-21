using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public PlayerCharacterController playerCharacterController;
    [SerializeField] FireHazardScriptableObject[] fireHazardScriptableObjects;
    [SerializeField] FireHazard[] fireHazards;

    private void Start()
    {
        foreach (FireHazard fireHazard in fireHazards)
        {
            //used as a "difficult settings" and edited in unity
            fireHazard.fireHazardData = 
                fireHazardScriptableObjects[Random.Range(0, fireHazardScriptableObjects.Length)];
            fireHazard.onCharacterEnteredAction += HandleCharacterEnteredFire;
        }
    }

    public void HandleCharacterEnteredFire(FireEnteredEventArgs args)
    {
        args.targetCharacterController.TakeDamage(args.damageDealt);
    }
}
