using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public ushort Amount;
    public GameObject star;
    void Start()
    {
        for (int i = 0; i < Amount; i++)
        {
            Instantiate(star, this.transform);
        }
    }
}
