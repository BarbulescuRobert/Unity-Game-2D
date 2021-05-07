using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Jbutton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool buttonPressed = false;
    public static bool jump = false;
   
    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
        jump = true;
        Player.extrajumps--;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
        jump = false;
    }
}