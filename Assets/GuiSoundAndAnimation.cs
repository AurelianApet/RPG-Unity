using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GuiSoundAndAnimation : MonoBehaviour
{
    public AudioSource guiClickSound;
    public AudioSource guiBlipSound;
    public EventSystem eventSystem;

    private PointerEventData pointerData;
    private bool buttonHovered = false;

    private bool pauseWhenGameIsPaused = true;
    private float previousTimeSinceStartup;
    private float privateDeltaTime = 0;
    private float timeSincePaused = 0;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (GameObject.FindGameObjectsWithTag("GuiLogic").Length > 1)
        {
            Destroy(this.gameObject);
        }

        previousTimeSinceStartup = Time.realtimeSinceStartup;
    }

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;

        pointerData = new PointerEventData(eventSystem);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);

        if (GameObject.Find("EventSystem"))
        {
            eventSystem = GameObject.Find("EventSystem").GetComponent<EventSystem>(); //Find UI Event System and assign it
            pointerData = new PointerEventData(eventSystem);
        }
        else if (GameObject.Find("EventSystem(Clone)"))
        {
            eventSystem = GameObject.Find("EventSystem(Clone)").GetComponent<EventSystem>(); //Find UI Event System for in-game menus and assign it
            pointerData = new PointerEventData(eventSystem);
        }
    }

    void Update()
    {
        if(eventSystem == null)
        {
            if (GameObject.Find("EventSystem"))
            {
                eventSystem = GameObject.Find("EventSystem").GetComponent<EventSystem>(); //Find UI Event System and assign it
                pointerData = new PointerEventData(eventSystem);
            }
            else if (GameObject.Find("EventSystem(Clone)"))
            {
                eventSystem = GameObject.Find("EventSystem(Clone)").GetComponent<EventSystem>(); //Find UI Event System for in-game menus and assign it.
                pointerData = new PointerEventData(eventSystem);
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Detect clicks on buttons and play a sound and animate the buttons
                GuiSoundAnimationLogic();
            }
        }
    }

    void GuiSoundAnimationLogic()
    {
        if (eventSystem != null)
        {
            if (eventSystem.currentSelectedGameObject != null) //Check if a UI object has been clicked
            {
                if (eventSystem.currentSelectedGameObject.GetComponent<Button>()) //Check if clicked object is a button
                {
                    if (eventSystem.currentSelectedGameObject.GetComponent<Button>().IsInteractable()) //Check if button is enabled and clickable
                    {
                        if (guiClickSound.isPlaying)
                        {
                            guiClickSound.Stop(); //Stop click sound if already playing
                        }

                        guiClickSound.Play(); //Play click sound
                    }
                }
            }
        }
    }
}
