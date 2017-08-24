using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public IPlayerState CurrentState;
    public LocomotionState LocomotionState;

    private void Awake()
    {
        LocomotionState = new LocomotionState();
    }

    // Use this for initialization
    void Start () {

        LocomotionState.Initialize(this);
        CurrentState = LocomotionState;

    }
	
	// Update is called once per frame
	void Update () {

        CurrentState.UpdateState();
       
        
    }


}
