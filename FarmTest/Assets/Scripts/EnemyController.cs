using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
    }

    private void Update()
    {
        if (CanMove())
        {
            return;
        }

        _agent.SetDestination(_player.position);
    }

    private bool CanMove()
    {
        return GameManager.Instance.IsFineshed;
    }
}
