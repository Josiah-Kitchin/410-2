using UnityEngine;
using Cinemachine; 

public class ZoomOut : MonoBehaviour
/*
    Use LERP to zoom the camera out starting the game 
*/
{
    public CinemachineVirtualCamera vcam;

    public float startFOV = 20f; 
    public float endFOV = 48f; 
    public float zoomDuration = 3f; 

    private float currentTime = 0f; 
    void Start()
    {
        vcam.m_Lens.FieldOfView = startFOV; 
    }

    void Update()
    {
        if (currentTime < zoomDuration)
        {
            currentTime += Time.deltaTime;
            float t = currentTime / zoomDuration;
            float newFOV = Mathf.Lerp(startFOV, endFOV, t);
            vcam.m_Lens.FieldOfView = newFOV;
        }
    }
}
