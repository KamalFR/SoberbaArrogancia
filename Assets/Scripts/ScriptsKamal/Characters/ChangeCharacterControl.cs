using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacterControl : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
<<<<<<< HEAD
    [SerializeField] private int jumpForce;
=======
    [SerializeField] private int JumpForce;
>>>>>>> 0db458e945e75b3f60bca185aeda83c9a8a22cbb
    [SerializeField] private int hugoBurroSpeed;
    private int actualCharacter;
    public PlayerBase player;
    private PlayerMovement playerMovement;
    private int normalSpeed;
<<<<<<< HEAD
    private bool canChange;
    private bool onFloor;
=======
>>>>>>> 0db458e945e75b3f60bca185aeda83c9a8a22cbb
    private void Start()
    {
        actualCharacter = 1;
        player = new HugoBurro();
        playerMovement = GetComponent<PlayerMovement>();
        normalSpeed = playerMovement.GetSpeed();
<<<<<<< HEAD
        player.EnterCharacter(this);
        canChange = true;
        onFloor = true;
=======
        player.EnterCharacter(bullet, JumpForce, playerMovement, hugoBurroSpeed);
>>>>>>> 0db458e945e75b3f60bca185aeda83c9a8a22cbb
    }
    // Update is called once per frame
    private void Update()
    {
        CharacterSelection();
<<<<<<< HEAD
        player.UpdateCharacter(this);
=======
>>>>>>> 0db458e945e75b3f60bca185aeda83c9a8a22cbb
    }
    private void CharacterSelection()
    {
        int ant = actualCharacter;
        if((Input.GetKeyDown(KeyCode.Alpha1))&&(actualCharacter != 1)) 
        {
            actualCharacter = 1;
            player = new HugoBurro();
            
        }
<<<<<<< HEAD
        if ((Input.GetKeyDown(KeyCode.Alpha2)) && (actualCharacter != 2) && (canChange))
=======
        if ((Input.GetKeyDown(KeyCode.Alpha2)) && (actualCharacter != 2))
>>>>>>> 0db458e945e75b3f60bca185aeda83c9a8a22cbb
        {
            actualCharacter = 2;
            player = new AlwaysZUp();
        }
<<<<<<< HEAD
        if ((Input.GetKeyDown(KeyCode.Alpha3)) && (actualCharacter != 3) && (canChange))
        {
            actualCharacter = 3;
            player = new Comander();
        }
        if ((Input.GetKeyDown(KeyCode.Alpha4)) && (actualCharacter != 4) && (canChange))
        {
            actualCharacter = 4;
            player = new Iuno();
        }
        if(ant != actualCharacter)
        {
            player.EnterCharacter(this);
        }
    }
    //funções para pegar os atributos mais faceis dentros dos estados 
    public GameObject GetBulletPrefab()
    {
        return bullet;
    }
    public int GetJumpForce()
    {
        return jumpForce;
    }
    public PlayerMovement GetPlayerMovement()
    {
        return playerMovement;
    }
    public int GetHugoBurroSpeed()
    {
        return hugoBurroSpeed;
    }
    public void BackToNormalSpeed()
    {
        playerMovement.SetSpeed(normalSpeed);
    }
    public bool GetOnFloor()
    {
        return onFloor;
    }
    public void SetOnFloor(bool set)
    {
        onFloor = set;
    }
    //ver se o Huguinho pode mudar para os outros personagens maiores
    private void OnTriggerEnter2D(Collider2D collision) //quando eu fico encostado e mudo pro Huguinho ele não registra a entrada
    {
        if (collision.tag == "Roof")
        {
            canChange = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Roof")
        {
            canChange = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision) //diminiu a bastante chance de bugar
    {
        if(collision.tag == "Roof")
        {
            canChange = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Floor")
        {
            onFloor = true;
=======
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
>>>>>>> 0db458e945e75b3f60bca185aeda83c9a8a22cbb
        }
    }
}
