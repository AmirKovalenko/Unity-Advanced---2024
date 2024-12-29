using UnityEngine;

public class BulletShooting : MonoBehaviour
{
    float fireRateDelay = 1.5f;
    int bulletDamage = 8;
    int bulletSpeed = 25;
    [SerializeField] GameObject bulletGO;
    UIManager uiManager;
    void Start()
    {
        uiManager = FindFirstObjectByType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fireRateDelay > 0)
        {
            fireRateDelay -= Time.deltaTime;
            if (fireRateDelay <= 0)
            {
                SpawnBullet();
            }
        }
    }

    private void SpawnBullet()
    {
        bulletGO.SetActive(true);
        fireRateDelay = 1.5f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            uiManager.TakeDamage(bulletDamage);
        }
        bulletGO.SetActive(false);
    }

    //public void InvokeDamage(int damage)
    //{
    //    damage = bulletDamage;
    //    uiManager.TakeDamage(damage);
    //}
}
