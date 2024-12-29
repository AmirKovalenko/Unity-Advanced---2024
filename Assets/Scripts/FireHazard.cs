using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class FireHazard : MonoBehaviour
{
    [SerializeField] int damageAmount = 10;
    public event UnityAction<FireEnteredEventArgs> onCharacterEnteredAction;

    //[SerializeField] private FireHazardScriptableObject fireHazardData;

    [SerializeField]
    private UnityEvent<FireEnteredEventArgs> onCharacterEntered = new UnityEvent<FireEnteredEventArgs>();

    // public void SetScriptableData(FireHazardScriptableObject fireHazardScriptableObject)
    // {
    //     fireHazardData = fireHazardScriptableObject;
    // }
    // private void Start()
    // { 
    //     if(onCharacterEnteredAction != null)
    //        onCharacterEntered.AddListener(onCharacterEnteredAction);
    // }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered this hazard");
            FireEnteredEventArgs fireEnteredEventArgs = new FireEnteredEventArgs
            {
                damageDealt = damageAmount,
                targetCharacterController = other.GetComponent<PlayerCharacterController>()
            };
            onCharacterEntered?.Invoke(fireEnteredEventArgs);
            onCharacterEnteredAction.Invoke(fireEnteredEventArgs);
        }
    }
}

public class FireEnteredEventArgs
{
    public int damageDealt;
    public PlayerCharacterController targetCharacterController;
}
