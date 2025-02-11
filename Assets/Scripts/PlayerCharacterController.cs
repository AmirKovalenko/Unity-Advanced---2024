using System;
using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerCharacterController : MonoBehaviour
{
    private static readonly int SpeedAnimatorHash = Animator.StringToHash(name:"Speed");

    public event UnityAction<int> onTakeDamageEventAction;
    public UnityEvent<int> onTakeDamageEvent;

    [Header("Navigation")]
    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform[] pathWaypoints;
    [SerializeField] private GameObject playerGO; //used as a ref of player to disable when hp reaches 0

    [SerializeField] Animator animator;
    public int Hp
    {
        get => hp;
        set => hp = value;
    }
    private int hp = 100;
    private int startingHP;
    public int CurrentWaypointIndex
    {
        get => currentWaypointIndex;
        set => currentWaypointIndex = value;
    }
    private int currentWaypointIndex = 0;
    private bool isMoving = true;
    private bool hasBloodyBoots = true;

    public void ToggleMoving(bool shouldMove)
    {
        isMoving = shouldMove;
        if (navMeshAgent) 
            navMeshAgent.enabled = shouldMove;
    }

    public void SetDestination(Transform targetTransformWaypoint)
    {
        if (navMeshAgent)
            navMeshAgent.SetDestination(targetTransformWaypoint.position);
    }

    public void SetDestination(int waypointIndex)
    {
        SetDestination(pathWaypoints[waypointIndex]);
    }

    public void TakeDamage(int damageAmount)
    {
        hp -= damageAmount;
        float hpPercentLeft = (float) hp / startingHP;
        animator.SetLayerWeight(1, weight:(1 - hpPercentLeft));
        onTakeDamageEvent.Invoke(hp);
        onTakeDamageEventAction.Invoke(hp);

        if (hp <= 0)
            CharacterDie();
    }

    [ContextMenu("Take Damage Test")]
    private void TakeDamageTesting()
    {
        TakeDamage(10);
    }

    private void CharacterDie()
    {
        playerGO.SetActive(false);
    }

    private void Start()
    {
        startingHP = hp;
        onTakeDamageEvent.AddListener(onTakeDamageEventAction);  //add the unity action into the unity event list
        SetMudAreaCost();
        ToggleMoving(true);
        SetDestination(pathWaypoints[0]);
    }

    private void SetMudAreaCost()
    {
        if (hasBloodyBoots)
            navMeshAgent.SetAreaCost(3, 1);
    }

    private void Update()
    {
        if (isMoving && !navMeshAgent.isStopped && navMeshAgent.remainingDistance <= 0.1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= pathWaypoints.Length)
                currentWaypointIndex = 0;
            SetDestination(pathWaypoints[currentWaypointIndex]);
        }
        if (animator)
            animator.SetFloat(name: "Speed", (int)navMeshAgent.velocity.magnitude);

        

    }

    private void WalkSoundEffect()
    {
        
    }


}