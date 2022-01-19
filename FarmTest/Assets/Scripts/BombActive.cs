using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombActive : MonoBehaviour
{
    [SerializeField] private GameObject _particle;
    [SerializeField] private Material _bombBlick;
    [SerializeField] private ParticleSystem _particleSystem;

    private SpriteRenderer _spriteRenderer;
    private Material _defMat;

    private void OnEnable()
    {
        PlayerController.Explosion += PlayerController_Explosion;
    }

    private void OnDisable()
    {
        PlayerController.Explosion -= PlayerController_Explosion;
    }

    private void Awake()
    {

        _particleSystem = GetComponent<ParticleSystem>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _defMat = _spriteRenderer.material;
    }

    IEnumerator Explosion ()
    {
        var waiter = new WaitForSeconds(0.3f);

        _spriteRenderer.material = _bombBlick;
        yield return waiter;
        _spriteRenderer.material = _defMat;
        yield return waiter;
        _spriteRenderer.material = _bombBlick;

        _particleSystem.Play();
        yield return waiter;

        Destroy(gameObject);
    }

    private void PlayerController_Explosion()
    {
        StartCoroutine(Explosion());
    }
}
