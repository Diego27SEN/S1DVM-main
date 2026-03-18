using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int x;
    public int y;
    public int z;
    private void Awake()
    {
        //print("GameManager Awake");
    }
    private void OnEnable()
    {
       // print("GameManager Enabled");
    }
    void Start()
    {
       // print("start");
    }
    

    void Update()
    {
        x++;
    }
    private void FixedUpdate()
    {
        y++;
    }
    private void LateUpdate()
    {
        z++;
    }
    private void OnDisable()
    {
        //print("GameManager Disabled");
    }
    private void OnDestroy()
    {
       // print("GameManager Destroyed");
    }
    private void OnDrawGizmos()
    {

        //vector3.zero
        //transform.position
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, transform.forward * 5f);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 3f);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, Vector3.zero);
        

        Gizmos.DrawWireCube(transform.position, Vector3.one *2f);



    }
}
