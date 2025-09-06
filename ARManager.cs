// ARManager für die Verwaltung der Augmented Reality-Features

using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARManager : MonoBehaviour
{
    private ARSession arSession;
    private ARMeshManager arMeshManager;

    void Awake()
    {
        arSession = GetComponent<ARSession>();
        arMeshManager = GetComponent<ARMeshManager>();

        if (arSession == null)
        {
            Debug.LogError("ARSession component is missing from this GameObject.");
        }

        if (arMeshManager == null)
        {
            Debug.LogError("ARMeshManager component is missing from this GameObject.");
        }
    }

    public void StartAR()
    {
        arSession.enabled = true;
        arMeshManager.enabled = true; // Enable the ARMeshManager as well
        Debug.Log("Augmented Reality features have been started.");
    }
}