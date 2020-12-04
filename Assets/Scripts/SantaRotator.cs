using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class SantaRotator : MonoBehaviour
{
    Vector3 latestPos;

    void Start()
    {
        this.UpdateAsObservable()
            .Subscribe(_ =>
            {
                Vector3 diff = transform.position - latestPos;

                if (diff.magnitude > 0.01f)
                {
                    transform.rotation = Quaternion.LookRotation(diff);
                }

                latestPos = transform.position;
            }).AddTo(gameObject);
    }
}
