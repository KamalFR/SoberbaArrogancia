using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBase 
{
    public abstract void EnterCharacter(ChangeCharacterControl player);
    public abstract void UpdateCharacter(ChangeCharacterControl player);
}
