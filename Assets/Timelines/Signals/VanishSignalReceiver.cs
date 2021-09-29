using UnityEngine;
using UnityEngine.Playables;

namespace Timelines.Signals
{
  public class VanishSignalReceiver : MonoBehaviour, INotificationReceiver//UnityEngine.Timeline.SignalReceiver
  {
    public void OnNotify(Playable origin, INotification notification, object context)
    {
      if (notification is EnemyVanishEmitter)
      {
        Destroy(gameObject);
      }
    }
  }
}
