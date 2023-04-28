using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTest : MonoBehaviour
{
    public void OnPointerDownCallback(BaseEventData data)
    {
        Debug.Log("Pointer down");
    }

    public void OnPointerUpCallback(BaseEventData data)
    {
        Debug.Log("Pointer up");
    }

    public void OnDragCallback(BaseEventData data)
    {
        Debug.Log("Drag");
    }

    public void OnClickCallback(BaseEventData data)
    {
        Debug.Log("Click");
    }

    public void OnHoldCallback(BaseEventData data)
    {
        Debug.Log("Hold");
    }
    public void OnBeginDragCallback(BaseEventData data)
    {
        Debug.Log("BeginDrag");
    }
    public void OnEndDragCallback(BaseEventData data)
    {
        Debug.Log("EndDrag");
    }
}
