using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    [SerializeField] private Rigidbody2D _rigidbody;


    public Mover Mover => _mover;
    public Rigidbody2D RootRigidbody;
}


