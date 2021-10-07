using UnityEngine;

public class SpawnerEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;

    private void Awake()
    {
        Instantiate(boxPrefab);
        Instantiate(boxPrefab, new Vector3(3, 3, 0), Quaternion.identity);
        Instantiate(boxPrefab, new Vector3(-1, -2, 0), Quaternion.identity);
        Instantiate(boxPrefab, new Vector3(1, 2, 0), Quaternion.identity);
        Instantiate(boxPrefab, new Vector3(-1, 2, 0), Quaternion.identity);
    }
}
