using UnityEngine;
public class Projectile : MonoBehaviour
{
    [SerializeField] protected float deviationAmount;
    [SerializeField] protected float fireRate;
    [SerializeField] protected float fireVelocity;
    [SerializeField] protected float lifeTime;
    [SerializeField] protected float maxRange;
    [SerializeField] protected int cost;
    [SerializeField] protected int damage;

    public float getDeviationAmount() { return deviationAmount; }
    public float getFireRate() { return fireRate; }
    public float getFireVelocity() { return fireVelocity; }
    public int getCost() { return cost; }
    public int getDamage() { return damage; }
    protected bool deleteSelf()
    {
        lifeTime -= 1 * Time.deltaTime;
        if (transform.position.z > maxRange)
        {
            return true;
        };
        if (lifeTime <= 0)
        {
            return true;
        };
        return false;
    }
}