using UnityEngine;
public class BigBullet : Projectile
{
    [SerializeField] private GameObject self;
    [SerializeField] private Rigidbody rgBody;

    void Start()
    {
        rgBody.AddForce(transform.forward * Random.Range(-1, 1));
        rgBody.AddForce(transform.right * Random.Range(-1, 1));
        rgBody.AddForce(transform.up * getFireVelocity());
    }

    // Update is called once per frame
    void Update()
    {
        if (deleteSelf())
        {
            Destroy(self);
        }
    }
}
