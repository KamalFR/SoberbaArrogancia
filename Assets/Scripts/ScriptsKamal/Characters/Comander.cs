using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comander : PlayerBase
{
<<<<<<< HEAD
    private GameObject bullet; 
    public override void EnterCharacter(ChangeCharacterControl player)
    {
        player.GetComponent<PolygonCollider2D>().enabled = false;
        player.GetComponent<BoxCollider2D>().isTrigger = false;
        player.GetPlayerMovement().SetSpeed(0);
        bullet = player.GetBulletPrefab();
    }
    public override void UpdateCharacter(ChangeCharacterControl player)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shootedBullet = MonoBehaviour.Instantiate(bullet, player.transform.position + player.GetPlayerMovement().GetLastMove(), Quaternion.identity);
            shootedBullet.GetComponent<BulletScript>().SetBulletTragetory(player.GetPlayerMovement().GetLastMove()); 
        }
=======
    public override void EnterCharacter(GameObject bullet, int JumpForce, PlayerMovement playerMovement, int hugoBurroSpeed)
    {
        throw new System.NotImplementedException();
    }
    public override void UpdateCharacter()
    {
        throw new System.NotImplementedException();
>>>>>>> 0db458e945e75b3f60bca185aeda83c9a8a22cbb
    }
}
