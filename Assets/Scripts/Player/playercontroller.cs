
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float budget;
    [SerializeField] private GameObject crosshair;
    [SerializeField] private Camera view;
    public List<Projectile> projectiles;
    private Projectile currentProjectile;
    private Quaternion lookAngle;
    private float deviationAmount;
    private bool permissionToShoot;
    private float countdown;
    private float fireRate;

    public float getBudget()
    {
        return budget;
    }

    void Start()
    {
        currentProjectile = projectiles[1];
        fireRate = currentProjectile.getFireRate();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && permissionToShoot && budget > 0)
        {
            createProjectile();
        }
        time(fireRate);
    }

    void time(float amount)
    {
        if (!permissionToShoot && countdown > 0)
        {
            countdown -= 1 * Time.deltaTime;
        }
        else
        {
            permissionToShoot = true;
            countdown = Random.Range(amount * 0.9f, amount * 1.1f);
        }
    }

    void createProjectile()
    {
        currentProjectile = projectiles[1];
        deviationAmount = currentProjectile.getDeviationAmount();
        fireRate = currentProjectile.getFireRate();
        budget -= currentProjectile.getCost() * Random.Range(0.9f, 1.1f);
        lookAngle = Quaternion.LookRotation((crosshair.transform.position - transform.position).normalized);
        lookAngle *= Quaternion.Euler(90 + Random.Range(-deviationAmount, deviationAmount), Random.Range(-deviationAmount, deviationAmount), Random.Range(-deviationAmount, deviationAmount));
        Instantiate(currentProjectile, new Vector3(0, 0, 0), lookAngle);
        permissionToShoot = false;
    }
}