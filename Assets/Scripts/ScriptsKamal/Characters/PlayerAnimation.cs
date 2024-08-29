using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer hugoBurro;
    [SerializeField] private SpriteRenderer alwaysZUp;
    [SerializeField] private SpriteRenderer comander;
    [SerializeField] private SpriteRenderer iuno;
    private PlayerMovement playerMovement;
    private ChangeCharacterControl characterControl;
    private Rigidbody2D rb;
    private bool isDoubleJumping;
    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        characterControl = GetComponent<ChangeCharacterControl>();
        rb = GetComponent<Rigidbody2D>();
        isDoubleJumping = false;
    }
    private void Update()
    {
        ActiveAnimation();
    }
    private void ActiveAnimation()
    {
        if(characterControl.GetActualCharacter()== Grupo3Protagonistas.HugoBurro)
        {
            hugoBurro.enabled = true;
            alwaysZUp.enabled = false;
            //comander.enabled = false;
            iuno.enabled = false;
            HugoBurroAnimation();
        }
        if (characterControl.GetActualCharacter() == Grupo3Protagonistas.AlwaysZUp)
        {
            hugoBurro.enabled = false;
            alwaysZUp.enabled = true;
            //comander.enabled = false;
            iuno.enabled = false;
            AlwaysZUpAnimation();
        }
        if (characterControl.GetActualCharacter() == Grupo3Protagonistas.Comander)
        {
            hugoBurro.enabled = false;
            alwaysZUp.enabled = false;
            //comander.enabled = true;
            iuno.enabled = false;
        }
        if (characterControl.GetActualCharacter() == Grupo3Protagonistas.Iuno)
        {
            hugoBurro.enabled = false;
            alwaysZUp.enabled = false;
            //comander.enabled = false;
            iuno.enabled = true;
            IunoAnimation();
        }
    }
    private void HugoBurroAnimation()
    {
        AnimatorHelper animatorHelper = hugoBurro.gameObject.GetComponent<AnimatorHelper>();
        if(rb.velocity.x == 0f)
        {/*
            if (playerMovement.GetLastLook().x > 0f)
            {
                animatorHelper.SetAnimation("HugoBurroIdle");
            }
            else
            {
                animatorHelper.SetReverseAnimation("HugoBurroIdle");
            }*/
        }
        if (rb.velocity.x > 0f)
        {
            animatorHelper.SetAnimation("HugoBurroWalk");
        }
        if (rb.velocity.x < 0f)
        {
            animatorHelper.SetReverseAnimation("HugoBurroWalk");
        }
    }
    private void AlwaysZUpAnimation()
    {
        AnimatorHelper animatorHelper = alwaysZUp.gameObject.GetComponent<AnimatorHelper>();
        
        if (rb.velocity.y == 0f)
        {
            isDoubleJumping = false;
            if (rb.velocity.x == 0f)
            {
                if (playerMovement.GetLastLook().x > 0f)
                {
                    animatorHelper.SetAnimation("JeffIdle");
                }
                else
                {
                    animatorHelper.SetReverseAnimation("JeffIdle");
                }
            }
            if (rb.velocity.x > 0f)
            {
                animatorHelper.SetAnimation("JeffRun");
            }
            if (rb.velocity.x < 0f)
            {
                animatorHelper.SetReverseAnimation("JeffRun");
            }
        }
        else
        {
            if(rb.velocity.y > 0f)
            {
                if (!isDoubleJumping)
                {
                    if(rb.velocity.x == 0f)
                    {
                        if(playerMovement.GetLastLook().x > 0f)
                        {
                            animatorHelper.SetAnimation("JeffJump");
                        }
                        else
                        {
                            animatorHelper.SetReverseAnimation("JeffJump");
                        }
                    }
                    if (rb.velocity.x > 0f)
                    {
                        animatorHelper.SetAnimation("JeffJump");
                    }
                    if (rb.velocity.x < 0f)
                    {
                        animatorHelper.SetReverseAnimation("JeffJump");
                    }
                }
                else
                {
                    if (rb.velocity.x == 0f)
                    {
                        if (playerMovement.GetLastLook().x > 0f)
                        {
                            animatorHelper.SetAnimation("JeffJetpack");
                        }
                        else
                        {
                            animatorHelper.SetReverseAnimation("JeffJetpack");
                        }
                    }
                    if (rb.velocity.x > 0f)
                    {
                        animatorHelper.SetAnimation("JeffJetpack");
                    }
                    if (rb.velocity.x < 0f)
                    {
                        animatorHelper.SetReverseAnimation("JeffJetpack");
                    }
                }
            }
            else
            {
                isDoubleJumping = false;
                if (rb.velocity.x == 0f)
                {
                    if (playerMovement.GetLastLook().x > 0f)
                    {
                        animatorHelper.SetAnimation("JeffFalling");
                    }
                    else
                    {
                        animatorHelper.SetReverseAnimation("JeffFalling");
                    }
                }
                if(rb.velocity.x > 0f)
                {
                    animatorHelper.SetAnimation("JeffFalling");
                }
                if (rb.velocity.x < 0f)
                {
                    animatorHelper.SetReverseAnimation("JeffFalling");
                }
            }
        }
    }
    private void ComanderAnimation()
    {

    }
    private void IunoAnimation()
    {
        AnimatorHelper animatorHelper = iuno.gameObject.GetComponent<AnimatorHelper>();
        if (rb.velocity.x == 0f)
        {
            animatorHelper.SetAnimation("IunoIdle");
        }
        if (rb.velocity.x > 0f)
        {
            animatorHelper.SetAnimation("IunoWalk");
        }
        if (rb.velocity.x < 0f)
        {
            animatorHelper.SetReverseAnimation("IunoWalk");
        }
    }
    public void SetIsDoubleJumping(bool set)
    {
        isDoubleJumping = set;
    }
}
