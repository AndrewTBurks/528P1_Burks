using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinklerSwitchBehavior : CAVE2Interactable
{
    public SprinklerBehavior targetScript;
    private bool isOn;
    public CAVE2.Button triggerButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnWandButtonDown(CAVE2.WandEvent evt)
    {
        CAVE2PlayerIdentity playerID = evt.playerID;
        int wandID = evt.wandID;
        CAVE2.Button button = evt.button;
        CAVE2.InteractionType interactionType = evt.interactionType;


        Debug.Log("OnWandButtonDown: " + playerID.name + " " + wandID + " " + button);

        if (button == triggerButton)
        {
            isOn = !isOn;

            targetScript.setSprinklerState(isOn);
        }


        //Debug.Log("OnWandButtonDown: ");
        //Debug.Log(evt);
    }
}
