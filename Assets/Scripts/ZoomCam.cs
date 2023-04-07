using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCam : MonoBehaviour
{
    private Camera cam;
    public float ZoomX;
    public AudioSource Myfx;
    void Start()
    {
        cam = GetComponent<Camera>();
    }
    
    void Update()
    {
        if ((Input.GetAxis("Mouse ScrollWheel") > 0) && (cam.fieldOfView > 10))
        {
            cam.fieldOfView--;
            Myfx.Play();
        }
        if ((Input.GetAxis("Mouse ScrollWheel") < 0) && (cam.fieldOfView < 60))
        {
            cam.fieldOfView++;
            Myfx.Play();
        }
        if (Input.GetAxis("Mouse ScrollWheel") == 0)
        {
            Myfx.Stop();
        }
        ZoomX = (float) System.Math.Round(60 / cam.fieldOfView, 1);
        LevelController.levelController.SetZoomText(ZoomX);
    }
}
