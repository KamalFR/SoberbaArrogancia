using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Comander : PlayerBase
{
    private GameObject bullet;
    private float time;
    public override void EnterCharacter(ChangeCharacterControl player)
    {
        player.GetComponent<PolygonCollider2D>().enabled = false;
        player.GetComponent<BoxCollider2D>().isTrigger = false;
        player.GetPlayerMovement().SetSpeed(0);
        bullet = player.GetBulletPrefab();
        player.SetIsIuno(false);
        time = 0f;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
    public override void UpdateCharacter(ChangeCharacterControl player)
    {
        if((Input.GetKeyDown(KeyCode.Space))&&(player.GetComponent<PlayerAnimation>().GetShootAnimationFinished()))
        {
            GameObject shootedBullet = MonoBehaviour.Instantiate(bullet, player.transform.position + player.GetPlayerMovement().GetLastLook(), Quaternion.identity);
            shootedBullet.GetComponent<BulletScript>().SetBulletTragetory(player.GetPlayerMovement().GetLastLook());
            player.GetComponent<PlayerAnimation>().SetShootAnimationFinished(false);
        }
        if (!(player.GetComponent<PlayerAnimation>().GetShootAnimationFinished()))
        {
            time += Time.deltaTime;
            if(time >= 0.4f)
            {
                time = 0f;
                player.GetComponent<PlayerAnimation>().SetShootAnimationFinished(true);
            }
        }
    }
}
