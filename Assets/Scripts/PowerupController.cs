using UnityEngine;

public class PowerupController :MonoBehaviour
{
    #region Field Declarations

    public GameObject explosion;

    [SerializeField]
    private PowerType powerType;

    #endregion

    #region Starup
    private void Start()
    {
        EventBroker.EndGame += GameSceneController_EndGame;
    }
    #endregion

    #region Movement

    void Update()
    {
       Move();
    }

    private void Move()
    {
        transform.Translate(Vector2.down * Time.deltaTime * 3, Space.World);

        if (ScreenBounds.OutOfBounds(transform.position))
        {
            EventBroker.EndGame -= GameSceneController_EndGame; 
            Destroy(gameObject);
        }
    }

    private void GameSceneController_EndGame()
    {
        Destroy(gameObject);
    }

    #endregion

    #region Collisons

    private void OnCollisionEnter2D(Collision2D collision)
    {
       //TODO: Apply Power ups
       if(powerType == PowerType.Shield)
        {
            PlayerController playerShip = collision.gameObject.GetComponent<PlayerController>();
            if(playerShip != null)
                playerShip.EnableShield();
        }
        Destroy(gameObject);
    }
    #endregion
}

public enum PowerType
{
    Shield,
    X2
};