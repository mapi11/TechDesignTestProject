using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class FirstSceneScript : MonoBehaviour
{
    public Animator FirstAnim;


    public void PressFirtsSprite()
    {
        Debug.Log("First");
    }
    public void PressSecondSprite()
    {
        Debug.Log("Second");
    }

}
