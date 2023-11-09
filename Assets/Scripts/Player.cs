using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Player : MonoBehaviour
{
    //Getting the move speed and direction for the players
    [Header("Movement")]
    private Vector2 _moveDir;
    [SerializeField] private float _moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
    //Activating the InputManager and Controls
        InputManager.Init(this , this);
        InputManager.EnableInGame();

    }

    // Update is called once per frame
    void Update()
    {
    //updating the position of the players
        transform.position += (Vector3)(_moveSpeed * Time.deltaTime * _moveDir);

    }
    //letting the code know where the player is going next 
    public void SetMoveDirection(Vector2 newDir)
    {
        _moveDir = newDir;
    }


}
