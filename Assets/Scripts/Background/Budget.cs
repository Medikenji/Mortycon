using TMPro;
using UnityEngine;

public class Budget : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI self;
    [SerializeField] PlayerController player;
    private float budget;
    void Start()
    {
        budget = -1;
    }

    // Update is called once per frame
    void Update()
    {
        budget = player.getBudget();
        self.text = budget.ToString("n0");
    }
}
