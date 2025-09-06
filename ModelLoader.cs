// ModelLoader für das Laden von 3D-Modellen

using UnityEngine;

public class ModelLoader : MonoBehaviour
{
    public GameObject modelPrefab;

    public void LoadModel(Vector3 position, Quaternion rotation = default)
    {
        Instantiate(modelPrefab, position, rotation);
        Debug.Log("Modell geladen.");
    }
}