using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public PlayerCharacterController playerCharacterController;
    [SerializeField] FireHazard[] fireHazards;
    // [SerializeField] FireHazardScriptableObject[] fireHazardScriptableObjects;

    //private void Start()
    //{
    //    foreach (FireHazard fireHazard in fireHazards)
    //    {
    //        fireHazard.onCharacterEnteredAction += HandleCharacterEnteredFire;
    //    }

    //}

    //public void HandleCharacterEnteredFire(FireEnteredEventArgs args)
    //{
    //    args.targetCharacterController.TakeDamage(args.damageDealt);
    //}
}
