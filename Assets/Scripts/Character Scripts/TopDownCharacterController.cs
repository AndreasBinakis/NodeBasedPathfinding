using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TopDownCharacterController : MonoBehaviour/*, IDataPersistence*/
{
    private Rigidbody2D rb;

    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 dir = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            dir.x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir.x = 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            dir.y = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dir.y = -1;
        }

        dir.Normalize();
        rb.velocity = speed * dir;
    }

    //public void SaveData(GameData data)
    //{
    //    data.playerPosition = this.transform.position;
    //}

    //public void LoadData(GameData data)
    //{
    //    this.transform.position = data.playerPosition;
    //}
}
