using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicHero : Card {

    public HeroData MyData;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void UpdateCardText()
    {
        base.UpdateCardText();
        
    }

    public void Attack()
    {
        //Gets the Attack of this card
    }

    public void ActivateEffect()
    {
        //Use its effect depending on what it is
    }

    public void IncreaseHP()
    {
        //Increase HP to the cap or adjust the cap?
    }

    public void ReduceHP()
    {
        //When you reduce HP if HP is 0 set start Death;
    }

    void Death()
    {
        //Remove this card from the field and use death effect if applicable
    }

    public void AdjustAttack()
    {
        //Used to increase/Decrease attack
    }
}
