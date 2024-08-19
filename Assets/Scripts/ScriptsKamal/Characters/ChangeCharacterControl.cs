using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacterControl : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private int JumpForce;
    [SerializeField] private int hugoBurroSpeed;
    private int actualCharacter;
    public PlayerBase player;
    private PlayerMovement playerMovement;
    private int normalSpeed;
    private void Start()
    {
        actualCharacter = 1;
        player = new HugoBurro();
        playerMovement = GetComponent<PlayerMovement>();
        normalSpeed = playerMovement.GetSpeed();
        player.EnterCharacter(bullet, JumpForce, playerMovement, hugoBurroSpeed);
    }
    // Update is called once per frame
    private void Update()
    {
        CharacterSelection();
    }
    private void CharacterSelection()
    {
        int ant = actualCharacter;
        if((Input.GetKeyDown(KeyCode.Alpha1))&&(actualCharacter != 1)) 
        {
            actualCharacter = 1;
            player = new HugoBurro();
            
        }
        if ((Input.GetKeyDown(KeyCode.Alpha2)) && (actualCharacter != 2))
        {
            actualCharacter = 2;
            player = new AlwaysZUp();
        }
        if ((Input.GetKeyDown(KeyCode.Alpha3)) && (actualCharacter != 3))
        {
            actualCharacter = 3;
            player = new Iuno();
        }
        if ((Input.GetKeyDown(KeyCode.Alpha4)) && (actualCharacter != 4))
        {
            actualCharacter = 4;
            player = new Comander();
        }
        if(ant != actualCharacter)
        {
            playerMovement.SetSpeed(normalSpeed);
            player.EnterCharacter(bullet, JumpForce, playerMovement, hugoBurroSpeed);
        }
    }
}
