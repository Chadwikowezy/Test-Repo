﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour, ICharacter
{
    private Rigidbody2D rb;
    private Animator anim;
    private Player player;

    private float moveSpeed = 4;

    public Slider healthBar;

    public GameObject smokePrarticle;
    public GameObject itemDropOBJ;

    //base character stats
    [SerializeField]
    private int _baseMaxHealth;
    [SerializeField]
    private int _baseAttack;
    [SerializeField]
    private int _baseDefense;

    //current stats
    private int _currentHealth = 10;
    private int _currentMaxHealth = 10;
    private int _currentAttack;
    private int _currentDefense;

    private bool inPursuit = true;
    private bool usingSkill = false;

    #region Properties
    public int BaseMaxHealth
    {
        get { return _baseMaxHealth; }
        set { _baseMaxHealth = value; }
    }
    public int BaseAttack
    {
        get { return _baseAttack; }
        set { _baseAttack = value; }
    }
    public int BaseDefense
    {
        get { return _baseDefense; }
        set { _baseDefense = value; }
    }
    public int CurrentHealth
    {
        get { return _currentHealth; }
        set
        {
            _currentHealth = value;
            _currentHealth = Mathf.Clamp(_currentHealth, 0, _currentMaxHealth);
        }
    }
    public int CurrentMaxHealth
    {
        get { return _currentMaxHealth; }
        set
        {
            _currentMaxHealth = value;

            if (_currentHealth > _currentMaxHealth)
                _currentHealth = _currentMaxHealth;
        }
    }
    public int CurrentAttack
    {
        get { return _currentAttack; }
        set { _currentAttack = value; }
    }
    public int CurrentDefense
    {
        get { return _currentDefense; }
        set { _currentDefense = value; }
    }
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>();
        anim = GetComponentInChildren<Animator>();
        smokePrarticle.SetActive(false);
    }

    void Update()
    {
        if (transform.position.x <= player.transform.position.x && inPursuit == true)
        {
            anim.gameObject.transform.eulerAngles = new Vector2(0, 0);
            if (Vector2.Distance(transform.position, player.transform.position) >= 5f)
            {
                if (rb.velocity.magnitude <= 5f)
                {
                    rb.velocity = new Vector2(moveSpeed, 0);
                    anim.SetInteger("Idle", 0);
                    anim.SetInteger("run", 1);
                }
            }
            else if(Vector2.Distance(transform.position, player.transform.position) <= 7f)
            {
                inPursuit = false;
                StartCoroutine(abilityRandomizer());
            }
        }
        else if (transform.position.x > player.transform.position.x && inPursuit == true)
        {
            anim.gameObject.transform.eulerAngles = new Vector2(0, 180);
            if (Vector2.Distance(transform.position, player.transform.position) >= 5f)
            {
                if (rb.velocity.magnitude <= 5f)
                {
                    rb.velocity = new Vector2(-moveSpeed, 0);
                    anim.SetInteger("Idle", 0);
                    anim.SetInteger("run", 1);
                }
            }
            else if (Vector2.Distance(transform.position, player.transform.position) <= 7f)
            {
                inPursuit = false;
                StartCoroutine(abilityRandomizer());
            }
        }
    }
    #region string plugin function for what animation to play
    void animStringCaller(string abilityUsing)
    {
        anim.SetInteger("shield", 0);
        anim.SetInteger("frost", 0);
        anim.SetInteger("scythe", 0);
        anim.SetInteger("tempest", 0);
        anim.SetInteger("uncontrolled", 0);
        anim.SetInteger("wrath", 0);
        anim.SetInteger("jump", 0);
        anim.SetInteger("ascending", 0);
        anim.SetInteger("run", 0);
        anim.SetInteger("idle", 0);
        anim.SetInteger("fist", 0);
        anim.SetInteger("kick", 0);
        anim.SetInteger("vortex", 0);
        anim.SetInteger("ignition", 0);
        anim.SetInteger("arrow", 0);
        anim.SetInteger("lacerate", 0);
        anim.SetInteger(abilityUsing, 1);

    }
    #endregion

    IEnumerator abilityRandomizer()
    {
        Debug.Log("got to coroutine call");

        usingSkill = true;
        inPursuit = false;
        int useAttack = Random.Range(0, 13);
        if(useAttack == 1)
        {
            animStringCaller("lacerate");
        }
        else if (useAttack == 2)
        {
            animStringCaller("scythe");
        }
        else if (useAttack == 3)
        {
            animStringCaller("kick");
        }
        else if (useAttack == 4)
        {

        }
        else if (useAttack == 5)
        {

        }
        else if (useAttack == 6)
        {

        }
        else if (useAttack == 7)
        {

        }
        else if (useAttack == 8)
        {

        }
        else if (useAttack == 9)
        {

        }
        else if (useAttack == 10)
        {

        }
        else if (useAttack == 11)
        {

        }
        else if (useAttack == 12)
        {

        }
        yield return new WaitForSeconds(1.5f);
        animStringCaller("");
        inPursuit = true;
    }

    public void AlterHealth(float healthChange)
    {
        _currentHealth -= (int)healthChange;
        healthBar.value = (float)((float)_currentHealth / (float)_baseMaxHealth);

        if (_currentHealth <= 0)
            StartCoroutine(Death());
    }

    IEnumerator Death()
    {
        smokePrarticle.SetActive(true);
        yield return new WaitForSeconds(1);
        DetermineLoot();
        Destroy(gameObject);

    }

    public void DetermineLoot()
    {
        if (Random.value == 0.20)
        {
            Instantiate(itemDropOBJ, transform.position, Quaternion.identity);
        }

        if (Random.value == 0.15)
        {
            //Instantiate (ItemObject, transform.position, Quaternion.identity); 
        }

        if (Random.value == 0.10)
        {
            //Instantiate (ItemObject, transform.position, Quaternion.identity); 
        }

        if (Random.value == 0.05)
        {
            //Instantiate (ItemObject, transform.position, Quaternion.identity); 
        }

        if (Random.value == 0.01)
        {
            //Instantiate (ItemObject, transform.position, Quaternion.identity); 
        }
    }


}
