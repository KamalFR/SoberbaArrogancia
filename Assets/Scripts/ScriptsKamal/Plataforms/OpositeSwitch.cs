using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpositeSwitch : SwitchControl
{
    [SerializeField] BlackOrGray thisSwitchColor;
    public override void ActivePlataform()
    {
        BlackOrGrayControl.activeCollor = thisSwitchColor;
    }
    public void Update()
    {
        if (thisSwitchColor == BlackOrGrayControl.activeCollor)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<CircleCollider2D>().enabled = true;
        }
    }
}
