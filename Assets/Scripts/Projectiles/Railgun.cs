using UnityEngine;
public class Railgun : Projectile
{
    [SerializeField] private GameObject self;
    [SerializeField] private Rigidbody rgBody;

    void Start()
    {
        this.rgBody.AddForce(transform.up * getFireVelocity());
    }

    void Update()
    {
        if (deleteSelf())
        {
            Object.Destroy(self);
        }
    }
}
