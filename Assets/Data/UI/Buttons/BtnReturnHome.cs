using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnReturnHome : BaseButton
{
    protected override void Onclick()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
