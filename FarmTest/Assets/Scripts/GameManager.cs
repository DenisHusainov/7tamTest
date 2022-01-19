using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const string FirstScene = "SampleScene";

    public static GameManager Instance;

    public bool IsFineshed { get; private set; }
    

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        PlayerController.Explosion += PlayerController_Explosion;
        PlayerController.GameOver += PlayerController_GameOver;
    }

    private void OnDisable()
    {
        PlayerController.Explosion -= PlayerController_Explosion;
        PlayerController.GameOver -= PlayerController_GameOver;
    }

    private void PlayerController_Explosion()
    {
        IsFineshed = true;
    }

    private void PlayerController_GameOver()
    {
        IsFineshed = true;
    }
}
