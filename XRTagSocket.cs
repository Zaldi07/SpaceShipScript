using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
public class XRTagSocket : XRSocketInteractor
{

    public string targetTag;

    public override bool CanHover(IXRHoverInteractable interactable)
    {
        // Validasi 
        var interactableObject = interactable as MonoBehaviour;
        if (interactableObject == null || interactableObject.gameObject == null)
            return false;

        return base.CanHover(interactable) && interactableObject.gameObject.CompareTag(targetTag);
    }

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
       
        var interactableObject = interactable as MonoBehaviour;
        if (interactableObject == null || interactableObject.gameObject == null)
            return false;

        // Delegasikan ke metode dasar dan cek tag
        return base.CanSelect(interactable) && interactableObject.gameObject.CompareTag(targetTag);
    }
}
