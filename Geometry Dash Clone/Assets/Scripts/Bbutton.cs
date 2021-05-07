using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Bbutton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool buttonPressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
        Fbutton.move = -1;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
        Fbutton.move = 0;
    }
}