using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider2D))]
public class Finish : MonoBehaviour
{
    [SerializeField, Min(1)] private int _health;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.GetComponent<IEnemy>() != null)
        {
            GetDamage(other.transform.GetComponent<IEnemy>().GetEnemyDamage());
        }
    }


    public void GetDamage(int damage)
    {
        if (_health - damage < 0)
        {
            SceneManager.LoadScene(SceneManager.sceneCount);
        }

        _health -= damage;
    }
}