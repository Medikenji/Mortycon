
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public short sensitivity;
    public float crosshairScale;
    [SerializeField] private GameObject self;
    [SerializeField] private CameraController cam;
    private short zoomLevel;
    private float usedSensitivity;
    private float usedScale;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        zoomLevel = cam.getZoomLevel();
        usedSensitivity = (float)sensitivity * ((float)zoomLevel / 14);
        self.transform.rotation = Quaternion.LookRotation((cam.transform.position - transform.position).normalized);
        self.transform.rotation *= Quaternion.Euler(180, 0, 0);
        usedScale = crosshairScale * ((float)zoomLevel / 14);
        self.transform.localScale = new Vector3(usedScale, usedScale, 0.1f);
        if (Input.GetAxis("Mouse X") < 0 && transform.position.x > -6.5)
        {
            transform.position = transform.position + new Vector3(-usedSensitivity * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Mouse X") > 0 && transform.position.x < 6.5)
        {
            transform.position = transform.position + new Vector3(usedSensitivity * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Mouse Y") < 0 && transform.position.y > -3.5)
        {
            transform.position = transform.position + new Vector3(0, -usedSensitivity * Time.deltaTime, 0);
        }
        if (Input.GetAxis("Mouse Y") > 0 && transform.position.y < 3.5)
        {
            transform.position = transform.position + new Vector3(0, usedSensitivity * Time.deltaTime, 0);
        }
    }
}
