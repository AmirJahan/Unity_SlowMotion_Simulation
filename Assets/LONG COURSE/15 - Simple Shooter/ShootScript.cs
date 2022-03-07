using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject projectile;
    public Transform shootingPoint;
    public float projectileSpeed = 10;

    bool fire = false;

    private void Update ()
    {
        if (Input.GetButtonUp ("Fire1"))
        {
            fire = true;
        }
    }

    private void FixedUpdate ()
    {
        if (fire)
        {
            GameObject newProjectile = Instantiate (projectile,
                shootingPoint.position,
                projectile.transform.rotation);

            newProjectile.GetComponent<Rigidbody> ().velocity =
                new Vector3 (0,
                    projectileSpeed / 2.0f,
                    projectileSpeed);

            fire = false;
        }
    }

}