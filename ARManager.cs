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
    }

    public void StartAR()
    {
        arSession.enabled = true;
        Debug.Log("Augmented Reality gestartet.");
    }
}
