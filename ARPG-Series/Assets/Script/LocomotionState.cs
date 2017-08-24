using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LocomotionState : IPlayerState
{

    private PlayerController _player;
    private NavMeshAgent _agent;

    public void Initialize(PlayerController player)
    {
        _player = player;
        _agent = _player.GetComponent<NavMeshAgent>();
    }

    public void StartState()
    {
        
    }

    public void UpdateState()
    {
        if (Input.GetButton("Fire2"))
        {            
            Move(GetPoint());
        }        
    }

    private void Move(Vector3 targetPoint)
    {
        _agent.SetDestination(targetPoint);
    }

    private Vector3 GetPoint()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {

            if (hit.transform.gameObject.layer == 9)
            {
                return hit.point;
            }

        }

        return _player.transform.position;
    }
}
