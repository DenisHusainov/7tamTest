using UnityEngine;

public class BombPlanting : MonoBehaviour
{
   [SerializeField] private GameObject[] _stone;
   [SerializeField] private GameObject _bomb;

    private void Start()
    {
        var placeForBomb = _stone[Random.Range(0, _stone.Length)];
        _bomb.transform.position = placeForBomb.transform.position;
        placeForBomb.SetActive(false);
        _bomb.SetActive(true);
    }

}
