using UnityEngine;

public class PlayerController : MonoBehaviour {
    [Header("Movement")]
    public float speed = 5f;
    public float boundaryX = 8f;

    private void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 newPos = transform.position + new Vector3(move, 0, 0);
        newPos.x = Mathf.Clamp(newPos.x, -boundaryX, boundaryX);
        transform.position = newPos;
    }
}
