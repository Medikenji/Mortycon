using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject self;
    public float startSize;
    public float usedSize;
    public bool max;

    void Start()
    {
        max = true;
        usedSize = startSize;
    }
    // Update is called once per frame
    void Update()
    {
        if (usedSize < startSize * 2 && max)
        {
            usedSize += startSize * 2.5f * Time.deltaTime;
        }
        else
        {
            max = false;
            usedSize -= startSize * 5 * Time.deltaTime;
        }
        self.transform.localScale = new Vector3(usedSize, usedSize, usedSize);
        if (usedSize < 0)
        {
            Destroy(self);
        }
    }

    public void createExplosion(Vector3 position, float sizeInput)
    {
        startSize = Random.Range(sizeInput*0.9f, sizeInput*1.1f);
        self.transform.localScale = new Vector3(startSize, startSize, startSize);
        usedSize = startSize;
        Instantiate(self, position, Quaternion.identity);
    }
}
