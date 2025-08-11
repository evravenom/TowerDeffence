using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public abstract class Enemy : MonoBehaviour
{
    public int Damage;
    public float Speed;
    [Min(0)] public int Health;

    [SerializeField] protected List<GameObject> path;
    protected SpriteRenderer _spriteRenderer;
    private Vector2 point;


    private void FixedUpdate() => transform.position = Vector3.MoveTowards(transform.position, point, Speed * Time.fixedDeltaTime);
    private void Awake() => StartCoroutine(StartMoving());


    protected virtual IEnumerator StartMoving()
    {
        yield return null;

        foreach (GameObject point in path)
        {
            while (Vector2.Distance(transform.position, point.transform.position) > 0.1f)
            {
                this.point = point.transform.position;
                yield return null;
            }
        }
    }


    public void Initialize(List<GameObject> path) => this.path = path; 
}