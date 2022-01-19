using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIView : MonoBehaviour
{
   [SerializeField] private GameObject _gameOver;
   [SerializeField] private GameObject _winner;
    [SerializeField] private GameObject _restart;

    private void OnEnable()
    {
        PlayerController.GameOver += PlayerController_GameOver;
        PlayerController.Explosion += PlayerController_Explosion;
    }

    private void OnDisable()
    {
        PlayerController.GameOver -= PlayerController_GameOver;
        PlayerController.Explosion -= PlayerController_Explosion;
    }

    private void PlayerController_GameOver()
    {
        if (!_winner.activeInHierarchy)
        {
            _gameOver.SetActive(true);
            _restart.SetActive(true);
        }
    }

    private void PlayerController_Explosion()
    {
        _winner.SetActive(true);
    }
}
