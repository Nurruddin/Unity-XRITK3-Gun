using UnityEngine;
using UnityEngine.Events;

public class OnTargetReached : MonoBehaviour
{
    // public ConfigurableJoint joint;
    [Tooltip("Max distance between object and target")]
    public float threshold = 0.02f;
    public Transform target;
    public UnityEvent onReached;
    private bool wasReached = false;

    private void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        if (distance < threshold && !wasReached)
        {
            onReached.Invoke();
            wasReached = true;
        }
        else if (distance >= threshold)
        {
            wasReached = false;
        }

        // there might be a better way to detect full pull. but im not doing it for now

        // if (Mathf.Abs(joint.transform.localPosition.x) >= joint.linearLimit.limit)
        // {
        //     Debug.Log("Object fully pulled out!");
        //     onReached.Invoke();
        // }
    }
}
