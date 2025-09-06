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
        if (arSession != null) {
            arSession.enabled = true;
        }
        else {
            Debug.LogWarning("Attempted to start AR without a valid ARSession.");
        }

        if (arMeshManager != null) {
            arMeshManager.enabled = true; // Enable the ARMeshManager as well
        }
        else {
            Debug.LogWarning("Attempted to start AR without a valid ARMeshManager.");
        }

        Debug.Log("Augmented Reality features have been started.");
    }
}