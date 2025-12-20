using UnityEngine;

public class Task : MonoBehaviour {
    public enum TaskType { Tax, Customer, Supplier, Production }
    public TaskType Type;

    public float fallSpeed = 5f;

    private void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

        if (transform.position.y < -6f) // ушло ниже экрана
        {
            GameManager.Instance.MissTask();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.CatchTask(Type);
            Destroy(gameObject);
        }
    }
}
