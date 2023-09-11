using UnityEngine;
using UnityEngine.EventSystems;

public class UICursorCapture : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool cursorOverUI = false;

    //must implement for IPointerEnterHandler
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer Enter");
        cursorOverUI = true;
    }

    //Must implement for IPointerExitHandler
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer Exit");
        cursorOverUI = false;
    }
}
