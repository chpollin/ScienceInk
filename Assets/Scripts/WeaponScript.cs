using UnityEngine;

/// Launch projectile
public class WeaponScript : MonoBehaviour
{

    /// Projectile prefab for shooting
    public Transform bulletRef;


    /// Cooldown in seconds between two shots
    public float shootingRate = 0.25f;

    //--------------------------------
    // 2 - Cooldown
    //--------------------------------

    private float shootCooldown;
    bool isFacingLeft = false;

    void Start()
    {
        shootCooldown = 0f;
    }

    void Update()
    {
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
    }

    //--------------------------------
    // 3 - Shooting from another script
    //--------------------------------

    /// Create a new projectile if possible
    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            shootCooldown = shootingRate;

            // Create a new shot

            var shotTransform = Instantiate(bulletRef) as Transform;

            // Assign position
            shotTransform.position = transform.position;
            shotTransform.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, -1);

        }
    }

    /// Is the weapon ready to create a new projectile?
    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }
}
