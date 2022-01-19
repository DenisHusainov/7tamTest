using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Sprite[] _pigs;

    public static event Action GameOver = delegate { };
    public static event Action Explosion = delegate { };

    private SpriteRenderer _spriteRenderer;
    private BoxCollider2D _collider;

    private float _collX;
    private float _collY;

    public static bool IsLeft;
    public static bool IsRight;
    public static bool IsUp;
    public static bool IsDown;
    public static float Distance;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _collider = GetComponent<BoxCollider2D>();
        _collY = _collider.size.y;
        _collX = _collider.size.x;
    }

    private void FixedUpdate()
    {
        MoveController();
    }

    private void MoveController()
    {
        if (CanMove())
        {
            return;
        }

        if (IsRight)
        {
            transform.position = new Vector2(transform.position.x + Distance, transform.position.y);
            _spriteRenderer.sprite = _pigs[0];
        }

        if (IsLeft)
        {
            transform.position = new Vector2(transform.position.x - Distance, transform.position.y);
            _spriteRenderer.sprite = _pigs[1];
        }

        if (IsUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + Distance);
        }

        if (IsDown)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - Distance);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>())
        {
            GameOver();
        }
        if (collision.gameObject.GetComponent<BombActive>())
        {
            Explosion();
        }
    }

    private bool CanMove ()
    {
         return GameManager.Instance.IsFineshed;
    }

}
