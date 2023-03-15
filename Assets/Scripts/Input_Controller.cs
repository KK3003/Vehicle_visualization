using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Input_Controller : MonoBehaviour
{
    public GameObject AR_object;
    public Camera AR_Camera;
    public ARRaycastManager raycastManager;
    public List<ARRaycastHit> hits = new List<ARRaycastHit>();
    bool is_Spawned = false;
    ARPlaneManager planeManager;


    void Start()
    {
        planeManager = GameObject.Find("AR Session Origin").GetComponent<ARPlaneManager>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!is_Spawned)
            {
                Ray ray = AR_Camera.ScreenPointToRay(Input.mousePosition);
                if (raycastManager.Raycast(ray, hits))
                {
                    Pose pose = hits[0].pose;
                    Instantiate(AR_object, pose.position, pose.rotation);
                    is_Spawned = true;
                    SetAllPlanesActive();
                    planeManager.enabled = false;
                }
            }
        }
    }

    void SetAllPlanesActive()
    {
        foreach (var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }
    }
}