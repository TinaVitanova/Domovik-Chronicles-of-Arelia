using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Collider2D swordColider;
    public float damage = 3;

    Vector2 rightAttackOffset;

    // Start is called before the first frame update
    void Start()
    {
        rightAttackOffset = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AttackRight ()
    {
        swordColider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }
    public void AttackLeft ()
    {
        swordColider.enabled = true;
        transform.localPosition = new Vector2(rightAttackOffset.x * -1, rightAttackOffset.y);
    }
    public void StopAttack ()
    {
        swordColider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            EnemyScript enemy = other.GetComponent<EnemyScript>();
            if (enemy != null)
            {
                enemy.Health -= damage;
            }
        }
    }

}
