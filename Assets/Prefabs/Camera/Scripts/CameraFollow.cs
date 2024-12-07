using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector2 minCampos, maxCampos;
    public GameObject seguir;

    void Start()
    {
        
    }

    void Update()
    {
        float posX = seguir.transform.position.x;
        float posY = seguir.transform.position.y;

        transform.position = new Vector3(
            Mathf.Clamp(posX, minCampos.x, maxCampos.x),
            Mathf.Clamp(posY, minCampos.y, maxCampos.y), 
            transform.position.z);
    }

}
