using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public static class InputManager 
{
    private static Controls _controls;

    public static void Init(Player _player1, Player _player2)
    {
        _controls = new Controls();
        PlayerController _playerController1 = GameObject.Find("Player Controller").GetComponent<PlayerController>();
        //setting both one and two to the repective sprites via an array in Player controller
        _player1 = _playerController1._players[0];
        _player2 = _playerController1._players[1];

        //setting up Player 1's movement 
        _controls.InGame.Player1Movement.performed += _ =>
        {

            _player1.SetMoveDirection(_.ReadValue<Vector2>());
        };
        //setting up Player 2's movement 

        _controls.InGame.Player2Movement.performed += _ =>
        {
            _player2.SetMoveDirection(_.ReadValue<Vector2>());
        };

    }
    //Activating the Controls
    public static void EnableInGame()
    {
        _controls.InGame.Enable();
    }


}
