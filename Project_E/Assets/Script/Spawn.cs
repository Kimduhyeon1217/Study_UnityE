using UnityEngine;



public class Spawn : MonoBehaviour
{
    public GameObject targetPrefab;
    public Transform spawnPosition;
    public void SpawnTarget()
    {
        Instantiate(targetPrefab, spawnPosition.position, Quaternion.identity);
    }


}
