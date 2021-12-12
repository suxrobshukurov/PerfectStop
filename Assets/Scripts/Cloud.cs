using UnityEngine;


public class Cloud : MonoBehaviour
{
    public float SpeedMoveClouds = 0.1f;
    private float _yPosClouds;

    private void Start()
    {
        _yPosClouds = transform.position.y;

        int rand = Random.Range(0, 2);
        if (rand == 1)
            SpeedMoveClouds *= -1;
    }

    private void Update()
    {
        if (transform.position.y > _yPosClouds + 3f || transform.position.y < _yPosClouds - 3f)
            SpeedMoveClouds *= -1;

        transform.position += new Vector3(0, SpeedMoveClouds * Time.deltaTime, 0);
    }
}
