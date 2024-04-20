using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private GameObject self;
    private float scaler;
    void Start()
    {
        scaler = Random.Range(25, 125);
        self.transform.localScale = new Vector3(scaler, scaler, scaler);
        self.transform.position = new Vector3(Random.Range(-60000, 60000), Random.Range(-36000, 36000), Random.Range(10000, 100000));
        float angle = Random.Range(0f, Mathf.PI * 2f);
        float distance = Random.Range(10000f, 100000f);
        Vector3 spawnPosition = new Vector3(Mathf.Sin(angle) * distance, Random.Range(-20000, 20000), Mathf.Cos(angle) * distance);
        self.transform.position = spawnPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
