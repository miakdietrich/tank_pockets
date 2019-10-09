using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingController : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectilePrefab;
    public float projectileForce;
    public float holdTime;

    private Slider powerBar;
    private float powerBarTreshold = 10f;
    private float powerBarValue = 0f;
    private float startTime;

    // Awake is called when the script instance is being loaded.
    void Awake()
    {
        OnInit();
    }

    void OnInit() 
    {
        powerBar = GameObject.Find("Power Bar").GetComponent<Slider>();
        powerBar.minValue = 0f;
        powerBar.maxValue = 10f;
        powerBar.value = powerBarValue;
    }

    void SetPower()
    {
        if(Input.GetButtonDown("Fire1")) // Input.GetMouseButtonDown(0) breaks for some reason
        {   
            startTime = Time.time;
            powerBarValue += Time.deltaTime * powerBarTreshold;
            powerBar.value = powerBarValue;
        }

        if(Input.GetKey(KeyCode.Mouse0)) { // returns true while the key is pressed.
            powerBarValue += Time.deltaTime * powerBarTreshold;
            powerBar.value = powerBarValue;
        }
        
        if (Input.GetButtonUp("Fire1") && Time.time - startTime < powerBarTreshold)
        {
            holdTime = (Time.time - startTime);
            if(holdTime > 2) { // Checks holdTime so projectileForce is balanced 
                holdTime = 2;
                Debug.Log(holdTime);
                Shoot(holdTime * 100);
            } else {
                Shoot(holdTime * 100);
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        SetPower();
    }

    void Shoot(float projectileForce)
    {
        powerBarValue = 0f;
        powerBar.value = powerBarValue;

        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * projectileForce, ForceMode2D.Impulse);
    }
}
