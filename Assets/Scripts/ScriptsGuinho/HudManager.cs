using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudManager : MonoBehaviour
{
    public string hugoBool;
    public string alwaysBool;
    public string iunoBool;
    public string comanderBool;

    public Animator hudAnimator;

    private int _lastPlayer = 1;

    private void Awake()
    {
        hudAnimator.SetBool(hugoBool, true);
        hudAnimator.SetBool(alwaysBool, false);
        hudAnimator.SetBool(iunoBool, false);
        hudAnimator.SetBool(comanderBool, false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && _lastPlayer != 1)
        {
            hudAnimator.SetBool(hugoBool, true);
            hudAnimator.SetBool(alwaysBool, false);
            hudAnimator.SetBool(iunoBool, false);
            hudAnimator.SetBool(comanderBool, false);

            _lastPlayer = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && _lastPlayer != 2)
        {
            hudAnimator.SetBool(hugoBool, false);
            hudAnimator.SetBool(alwaysBool, true);
            hudAnimator.SetBool(iunoBool, false);
            hudAnimator.SetBool(comanderBool, false);

            _lastPlayer = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && _lastPlayer != 3)
        {
            hudAnimator.SetBool(hugoBool, false);
            hudAnimator.SetBool(alwaysBool, false);
            hudAnimator.SetBool(iunoBool, true);
            hudAnimator.SetBool(comanderBool, false);

            _lastPlayer = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) && _lastPlayer != 4)
        {
            hudAnimator.SetBool(hugoBool, false);
            hudAnimator.SetBool(alwaysBool, false);
            hudAnimator.SetBool(iunoBool, false);
            hudAnimator.SetBool(comanderBool, true);

            _lastPlayer = 4;
        }
    }
}
