using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void ChangeDistance(float changeDistance)
    {
        PlayerController.Distance = changeDistance;
    }

    public void RightEnter()
    {
        PlayerController.IsRight = true;
    }

    public void RightExit()
    {
        PlayerController.IsRight = false;
    }

    public void LeftEnter()
    {
        PlayerController.IsLeft = true;
    }

    public void LeftExit()
    {
        PlayerController.IsLeft = false;
    }

    public void UpEnter()
    {
        PlayerController.IsUp = true;
    }

    public void UpExit()
    {
        PlayerController.IsUp = false;
    }

    public void DownEnter()
    {
        PlayerController.IsDown = true;
    }

    public void DownExit()
    {
        PlayerController.IsDown = false;
    }

    public void Restart ()
    {
        SceneManager.LoadScene(GameManager.FirstScene);
    }
}
