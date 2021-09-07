using UnityEngine;

namespace Behaviours.Generator
{
  public class EnemyGenerator : MonoBehaviour
  {
    public GameObject stage;
    public GameObject enemyPrefab;
    public void Generate()
    {
      Instantiate(enemyPrefab, transform.localPosition, Quaternion.identity, stage.transform);
    }
  }
}

