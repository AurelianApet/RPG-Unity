using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachanimAnimator : MonoBehaviour {

    Animator animator;
    public bool idleStandbool = true;
    public bool idleReadybool = false;
    public bool idleMonsterbool = false;
    public bool idleFightbool = false;
    public bool weaponStandbool = false;
    public bool pistolReadybool = false;
    public bool weaponRun = false;
    public bool oneHandSwordIdle = false;
    public bool bowIdle = false;
    public bool motorbikeIdle = false;
    public bool rollerBlade = false;
    public bool skateboard = false;
    public bool climbing = false;
    public bool office = false;
    public bool swim = false;
    public bool wand = false;
    public bool cards = false;
    public bool breakdance = false;
    public bool katana = false;
    public bool soccer = false;
    public bool giant = false;
    public bool zombie = false;
    public bool iceHockey = false;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        IdleStand();
    }
    void IdleStand(){
        Falses();
        idleStandbool = true;
        animator.SetBool("IdleStand", true);
    }
    void RunBackward()
    {
        //IdleStand();
        animator.SetBool("RunBackward", true);
    }
  
    void IdleStandingJump()
    {
        animator.SetBool("IdleStandingJump", true);
    }
    void Update()
    {
        if (Input.GetAxis("Horizontal")!=0|| Input.GetAxis("Vertical")!=0)
        {
            RunBackward();
        }
        else
        {
            IdleStand();
        }
        if(Input.GetButtonDown("Jump"))
        {
            IdleStandingJump();
        }
        else
        {
            IdleStand();
        }
      
    }
    void Falses(){
    	weaponStandbool = false;
    	idleStandbool = false;
    	idleReadybool = false;
    	idleMonsterbool = false;
    	idleFightbool = false;
    	weaponRun = false;
    	oneHandSwordIdle = false;
    	pistolReadybool = false;
		bowIdle = false;
		motorbikeIdle = false;
		rollerBlade = false;
		skateboard = false;
		climbing = false;
		office = false;
		swim = false;
		wand = false;
		cards = false;
		breakdance = false;
		katana = false;
		soccer = false;
		giant = false;
		zombie = false;
		iceHockey = false;

		animator.SetBool("IceHockeyGoalieReady", false);
		animator.SetBool("IceHockeyDekeMiddle", false);
		animator.SetBool("IceHockeyIdle", false);
		animator.SetBool("1HandSwordStrafeLeft", false);
		animator.SetBool("1HandSwordStrafeRight", false);
		animator.SetBool("ZombieCrawl", false);
		animator.SetBool("ZombieWalk", false);
		animator.SetBool("ZombieIdle", false);
		animator.SetBool("WoodSaw", false);
		animator.SetBool("BlackSmithHammer", false);
		animator.SetBool("GiantGrabIdle2", false);
		animator.SetBool("GiantGrabIdle", false);
		animator.SetBool("WallSit", false);
		animator.SetBool("WallRunLeft", false);
		animator.SetBool("WallRunRight", false);
		animator.SetBool("ScubaSwim", false);
		animator.SetBool("BackPackOff", false);
		animator.SetBool("SneakForward", false);
		animator.SetBool("SneakBackward", false);
		animator.SetBool("SneakLeft", false);
		animator.SetBool("SneakRight", false);
		animator.SetBool("SneakIdle", false);
		animator.SetBool("SoccerRun", false);
		animator.SetBool("SoccerSprint", false);
		animator.SetBool("SoccerWalk", false);
		animator.SetBool("SoccerKeeperReady", false);
		animator.SetBool("Katana", false);
		animator.SetBool("KatanaReadyHigh", false);
		animator.SetBool("KatanaReady", false);
		animator.SetBool("KatanaReadyLow", false);
		animator.SetBool("KatanaReady", false);
		animator.SetBool("KneesIdle", false);
		animator.SetBool("WalkInjured", false);
		animator.SetBool("SatNightFever", false);
		animator.SetBool("RunningDance", false);
		animator.SetBool("RussianDance", false);
		animator.SetBool("ElvisLegsLoop", false);
		animator.SetBool("Flashlight", false);
		animator.SetBool("WalkBackward", false);
		animator.SetBool("Windmill", false);
		animator.SetBool("Flares", false);
		animator.SetBool("DeadmanFloat", false);
		animator.SetBool("2000", false);
		animator.SetBool("SixStep", false);
		animator.SetBool("ChannelCastOmni", false);
		animator.SetBool("ChannelCastDirected", false);
		animator.SetBool("BowInstant2", false);
		animator.SetBool("BowReady2", false);
		animator.SetBool("WalkDehydrated", false);
		animator.SetBool("UpHillWalk", false);
		animator.SetBool("CardPlayerIdle", false);
		animator.SetBool("DealerIdle", false);
		animator.SetBool("StaffStand", false);
		animator.SetBool("WandStand", false);
		animator.SetBool("SwimDogPaddle", false);
		animator.SetBool("SwimFreestyle", false);
		animator.SetBool("Swim", false);
		animator.SetBool("WateringCan", false);
		animator.SetBool("OfficeSittingReadingLeanBack", false);
		animator.SetBool("OfficeSittingReading", false);
		animator.SetBool("OfficeSittingLegCross", false);
		animator.SetBool("OfficeSittingBack", false);
		animator.SetBool("OfficeSitting45DegLeg", false);
		animator.SetBool("OfficeSitting1LegStraight", false);
		animator.SetBool("OfficeSitting", false);
		animator.SetBool("ClimbUp", false);
		animator.SetBool("ClimbIdle", false);
		animator.SetBool("SkateboardIdle", false);
		animator.SetBool("IdleFeedThrow", false);
		animator.SetBool("RollerBladeCrossoverLeft", false);
		animator.SetBool("RollerBladeTurnLeft", false);
		animator.SetBool("RollerBladeTurnRight", false);
		animator.SetBool("RollerBladeSkateFwd", false);
		animator.SetBool("RollerBladeCrossoverRight", false);
		animator.SetBool("RollerBladeGrindRoyale", false);
		animator.SetBool("RollerBladeRoll", false);
		animator.SetBool("RollerBladeStand", false);
		animator.SetBool("CrouchStrafeLeft", false);
		animator.SetBool("CrouchStrafeRight", false);
		animator.SetBool("CrouchWalkBackward", false);
		animator.SetBool("ProneLocomotion", false);
		animator.SetBool("ProneIdle", false);
		animator.SetBool("CrawlLocomotion", false);
		animator.SetBool("CrawlIdle", false);
		animator.SetBool("RunBackRight", false);
		animator.SetBool("RunBackLeft", false);
		animator.SetBool("WorkerShovel2", false);
		animator.SetBool("WorkerShovel", false);
		animator.SetBool("WorkerPickaxe", false);
		animator.SetBool("WorkerPickaxe2", false);
		animator.SetBool("WorkerHammer2", false);
		animator.SetBool("WorkerHammer", false);
		animator.SetBool("WoodCut", false);
		animator.SetBool("MotorbikeLasso", false);
		animator.SetBool("MotorbikeWheelyNoHands", false);
		animator.SetBool("MotorbikeWheely", false);
		animator.SetBool("MotorbikeSeatStandWheely", false);
		animator.SetBool("MotorbikeSeatStand", false);
		animator.SetBool("MotorbikeLookBack", false);
		animator.SetBool("MotorbikeHeartAttack", false);
		animator.SetBool("MotorbikeHeadstand", false);
		animator.SetBool("MotorbikeHandstand", false);
		animator.SetBool("MotorbikeHandlebarSit", false);
		animator.SetBool("MotorbikeBackwardStand", false);
		animator.SetBool("MotorbikeBackwardSitting", false);
		animator.SetBool("MotorbikeAirWalk", false);
		animator.SetBool("MotorbikeIdle", false);
		animator.SetBool("IdleStun", false);
		animator.SetBool("1HandSwordChargeUp", false);
		animator.SetBool("WeaponRunBackward", false);
		animator.SetBool("RunBackward", false);
		animator.SetBool("1HSwordStrafeRunRight", false);
		animator.SetBool("1HSwordStrafeRunLeft", false);
		animator.SetBool("WeaponStrafeRunRight", false);
		animator.SetBool("WeaponStrafeRunLeft", false);
		animator.SetBool("StrafeRunRight", false);
		animator.SetBool("StrafeRunLeft", false);
		animator.SetBool("FlyUp", false);
		animator.SetBool("FlyDown", false);
		animator.SetBool("FlyRight", false);
		animator.SetBool("FlyLeft", false);
		animator.SetBool("FlyBackward", false);
		animator.SetBool("FlyForward", false);
		animator.SetBool("IdleFly", false);
		animator.SetBool("IdleMeditate", false);
		animator.SetBool("ShotgunReloadMagazine", false);
		animator.SetBool("BowReady", false);
		animator.SetBool("BowInstant", false);
		animator.SetBool("BowFire", false);
		animator.SetBool("IdleStrafeLeft", false);
		animator.SetBool("IdleStrafeRight", false);
		animator.SetBool("CratePull", false);
		animator.SetBool("CratePush", false);
		animator.SetBool("IdleWalk", false);
    	animator.SetBool("WeaponRun", false);
    	animator.SetBool("WeaponStand", false);
    	animator.SetBool("IdleReady", false);
    	animator.SetBool("IdleStand", false);
    	animator.SetBool("IdleMonster", false);
    	animator.SetBool("WeaponReady", false);
    	animator.SetBool("WeaponInstant", false);
    	animator.SetBool("IdleFight", false);
    	animator.SetBool("PistolReady", false);
    	animator.SetBool("PistolInstant", false);
    	animator.SetBool("OneHandSwordIdle", false);
    	animator.SetBool("OneHandSwordReady", false);
    	animator.SetBool("OneHandSwordRun", false);
		animator.SetBool("IdleRun", false);
		animator.SetBool("BowIdle", false);
		animator.SetBool("IdleReadyCrouch", false);
		animator.SetBool("CrouchWalk", false);
    }
}
