using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Networking;

public class Draggable : NetworkBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    void Update()
    {

        if (!isLocalPlayer)
        {
            return;
        }
    }

	public Transform parentToReturnTo = null;
	public bool activated = false;

	public void OnBeginDrag(PointerEventData eventData){

		parentToReturnTo = this.transform.parent;
		this.transform.SetParent(this.transform.parent.parent);

		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData){
		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData){
		this.transform.SetParent(parentToReturnTo);
		GetComponent<CanvasGroup>().blocksRaycasts = true;
	}
	
}