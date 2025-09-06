// ModelLoader für das Laden von 3D-Modellen

using UnityEngine;

public class ModelLoader : MonoBehaviour
{
    public GameObject modelPrefab;

    public void LoadModel(Vector3 position)
    {
        Instantiate(modelPrefab, position, Quaternion.identity);
        Debug.Log("Modell geladen.");
    }
}
