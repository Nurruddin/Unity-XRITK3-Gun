using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ModifyInteractionLayers : MonoBehaviour
{
    public XRGrabInteractable grabInteractable; // Reference to the XRGrabInteractable
    public XRSocketInteractor socketInteractor; // Reference to the XRSocketInteractor

    private void Start() { }

    public void ModifyLayer(string layerName)
    {
        if (grabInteractable != null)
        {
            // Remove the layer from the interaction layer mask
            grabInteractable.interactionLayers = InteractionLayerMask.GetMask(layerName);
        }

        if (socketInteractor != null)
            // Remove the layer from the socket's interaction layer mask
            socketInteractor.interactionLayers = InteractionLayerMask.GetMask(layerName);
    }
}
