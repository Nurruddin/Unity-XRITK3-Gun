using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ModifyInteractionLayers : MonoBehaviour
{
    public XRGrabInteractable grabInteractable; // Reference to the XRGrabInteractable
    public XRSocketInteractor socketInteractor; // Reference to the XRSocketInteractor
    public LayerMask layerToAdd; // The layer to add to the interaction mask
    public LayerMask layerToRemove; // The layer to remove from the interaction mask

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

    public void AddLayer()
    {
        if (grabInteractable != null)
            // Add the layer to the interaction layer mask
            grabInteractable.interactionLayers |= layerToAdd;

        if (socketInteractor != null)
            // Add the layer to the socket's interaction layer mask
            socketInteractor.interactionLayers |= layerToAdd;
    }
}
