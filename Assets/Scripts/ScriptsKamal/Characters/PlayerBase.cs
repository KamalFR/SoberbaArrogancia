using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public abstract class PlayerBase 
{
    public abstract void EnterCharacter(ChangeCharacterControl player);
    public abstract void UpdateCharacter(ChangeCharacterControl player);
=======
public abstract class PlayerBase : MonoBehaviour
{
    public abstract void EnterCharacter(GameObject bullet, int JumpForce, PlayerMovement playerMovement, int hugoBurroSpeed);
    public abstract void UpdateCharacter();
>>>>>>> 0db458e945e75b3f60bca185aeda83c9a8a22cbb
}
