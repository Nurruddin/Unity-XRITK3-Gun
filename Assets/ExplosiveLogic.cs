using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ExplosiveLogic : MonoBehaviour
{
    public XRBaseInteractor socketInteractor;
    bool isHolding = false;
    bool isPinned = true;

    // Start is called before the first frame update
    void Start()
    {
        socketInteractor.selectExited.AddListener(Unpin);
    }
    private void Update() {
        if (!isHolding && !isPinned)
        {
            Debug.Log("Blow up soon");
            Invoke("Explode", 5);
        }
    }
    public void Holding(bool holding)
    {
        isHolding = holding;
    }
    void Unpin(SelectExitEventArgs interactable)
    {
        isPinned = !isPinned;
    }
    void Explode()
    {
        Destroy(gameObject);
        Debug.Log("Boom");
    }


}
