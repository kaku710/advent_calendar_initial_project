using UnityEngine;

public class CameraMover : MonoBehaviour
{
   public Transform playerTransform;
    void Update()
    {
        transform.position = playerTransform.position + new Vector3(0, 5.5f, -4.5f);
    }
}
