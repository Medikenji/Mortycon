using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera self;
    public GameObject crossHair;
    private short zoomLevel;
    public short getZoomLevel()
    {
        return zoomLevel;
    }

    void Start()
    {
        zoomLevel = 14;
    }

    void Update()
    {
        crossHair.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        if (Input.GetKeyDown("w") && zoomLevel > 1)
        {
            zoomLevel--;
            self.transform.rotation = Quaternion.LookRotation((crossHair.transform.position - transform.position).normalized);
        }
        if (Input.GetKeyDown("s") && zoomLevel < 14)
        {
            zoomLevel++;
            self.transform.rotation = Quaternion.LookRotation((crossHair.transform.position - transform.position).normalized);
        }
        if (zoomLevel == 14)
        {
            self.transform.rotation = Quaternion.identity;
        }
        if (zoomLevel == 0)
        {
            crossHair.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        }
        self.fieldOfView = (zoomLevel * 5) + 1;
    }
}
