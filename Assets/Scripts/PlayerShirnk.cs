using System.Collections;
using System.Collections.Generic;
using KinematicCharacterController;
using KinematicCharacterController.Examples;
using UnityEngine;

public class PlayerShirnk : MonoBehaviour
{
    [Header("Visuals")]
    [SerializeField] private GameObject playerMager;
    [SerializeField] private Animator animator;
    [Space]
    [SerializeField] private float shrinkDuration;

    [Header("Funtionalities")]
    [SerializeField] private ExampleCharacterController kinematicCharacterController;
    [SerializeField] private Interactors interactors;
    [SerializeField] private ExampleCharacterCamera camera;

    public void Shrink()
    {
        animator.SetTrigger("Shrink");
        kinematicCharacterController.MaxStableMoveSpeed = 5;
        interactors.interactionPointRadius = 0.5f;
        camera.MaxDistance = 10;
        camera.DefaultDistance = 10;
        camera._currentDistance = 10;
    }

}
