using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Fbutton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool buttonPressed = false;
    public static int move = 0;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
        move = 1;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
        move = 0;
    }
}