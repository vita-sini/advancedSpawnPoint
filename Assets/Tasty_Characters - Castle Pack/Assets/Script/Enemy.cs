using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _direction;

    private bool _isMove;

    private void Update()
    {
        if (_isMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, _direction.position, _speed * Time.deltaTime);
        }
    }

    public void SetDirection(Transform direction)
    {
        _direction = direction;
        _isMove = true;
    }
}
