using UnityEngine;

namespace Behaviours.Generator
{
  public class EnemyGenerator : MonoBehaviour
  {
    public GameObject stage;
    public GameObject black;
    public GameObject white;
    public void Generate(int pos)
    {
      var x = -1.4f * pos;
      if (pos % 2 == 0)
      {
        Instantiate(white, new Vector3(x, 3), Quaternion.identity, stage.transform);
      }
      else
      {
        Instantiate(black, new Vector3(x, 4), Quaternion.identity, stage.transform);
      }
    }
  }
}
