using UnityEngine;
public class BigBullet : Projectile
{
    [SerializeField] private GameObject self;
    [SerializeField] private Rigidbody rgBody;

    void Start()
    {
        rgBody.AddForce(transform.forward * Random.Range(deviationAmount, deviationAmount));
        rgBody.AddForce(transform.right * Random.Range(deviationAmount, deviationAmount));
        rgBody.AddForce(transform.up * getFireVelocity());
    }

    // Update is called once per frame
    void Update()
    {
        if (deleteSelf())
        {
            explosion.createExplosion(transform.position, 0.1f);
            Destroy(self);
        }
    }
}
