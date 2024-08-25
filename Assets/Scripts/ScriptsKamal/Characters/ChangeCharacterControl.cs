using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacterControl : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private int jumpForce;
    [SerializeField] private int hugoBurroSpeed;
    private int actualCharacter;
    public PlayerBase player;
    private PlayerMovement playerMovement;
    private int normalSpeed;
    private bool canChange;
    private bool onFloor;
    private bool isIuno;
    private bool canInteract;
    private SwitchControl interactable;
    private void Start()
    {
        actualCharacter = 1;
        player = new HugoBurro();
        playerMovement = GetComponent<PlayerMovement>();
        normalSpeed = playerMovement.GetSpeed();
        player.EnterCharacter(this);
        canChange = true;
        onFloor = true;
        isIuno = false;
        canInteract = false;
    }
    // Update is called once per frame
    private void Update()
    {
        CharacterSelection();
        player.UpdateCharacter(this);
    }
    private void CharacterSelection()
    {
        int ant = actualCharacter;
        if((Input.GetKeyDown(KeyCode.Alpha1))&&(actualCharacter != 1)) 
        {
            actualCharacter = 1;
            player = new HugoBurro();
            
        }
        if ((Input.GetKeyDown(KeyCode.Alpha2)) && (actualCharacter != 2) && (canChange))
        {
            actualCharacter = 2;
            player = new AlwaysZUp();
        }
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
    public void SetIsIuno(bool set)
    {
        isIuno = set;
        if(set == false)
        {
            canInteract = false;
        }
    }
    public bool GetCanInteract()
    {
        return canInteract;
    }
    public void SetCanInteract(bool set)
    {
        canInteract = set;
    }
    public SwitchControl GetInteractable()
    {
        return interactable;
    }
    //ver se o Huguinho pode mudar para os outros personagens maiores
    private void OnTriggerEnter2D(Collider2D collision) //quando eu fico encostado e mudo pra alguem ele não registra a entrada
    {
        if (collision.tag == "Roof")
        {
            canChange = false;
        }
        if((collision.tag == "Switch") && (isIuno))
        {
            interactable = collision.GetComponent<SwitchControl>();
            canInteract = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Roof")
        {
            canChange = true;
        }
        if (collision.tag == "Switch")
        {
            canInteract = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision) //diminiu bastante chance de bugar
    {
        if(collision.tag == "Roof")
        {
            canChange = false;
        }
        if ((collision.tag == "Switch") && (isIuno))
        {
            interactable = collision.GetComponent<SwitchControl>();
            canInteract = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Floor")
        {
            onFloor = true;
        }
    }
}
