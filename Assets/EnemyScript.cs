using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public float Health
    {
        set
        {
            health = value;
            if(health <= 0)
            {
                Defeated();
            }
        }
        get { return health; }
    }

    public float health = 1;

    public void Defeated()
    {
        animator.SetTrigger("Defeated");
    }

    public void RemoveEnemy() { Destroy(gameObject); }
}
