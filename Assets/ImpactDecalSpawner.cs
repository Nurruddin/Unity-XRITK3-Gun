using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(UnityEngine.Rendering.Universal.DecalProjector))]
[RequireComponent(typeof(Rigidbody))]
public class ImpactDecalSpawner : MonoBehaviour
{
    private Rigidbody rb;
    private MeshRenderer meshRenderer;
    private UnityEngine.Rendering.Universal.DecalProjector decalProjector;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        
        meshRenderer = GetComponent<MeshRenderer>();
        decalProjector = GetComponent<UnityEngine.Rendering.Universal.DecalProjector>();
    }

    private void OnCollisionEnter(Collision other) 
    {
        rb.isKinematic = true;
        meshRenderer.enabled = false;
        decalProjector.enabled = true;
        // Invoke("DestroyThis", 5);
    }
    
    private void DestroyThis(){
        Destroy(gameObject);
    }
}
