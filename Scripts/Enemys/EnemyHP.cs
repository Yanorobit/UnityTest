

public class EnemyHP : Entyti
{
    public General general;
   override protected void Prepear()
    {
        base.Prepear();
        general.AddNPC();
    }
    override protected void Death()
    {
        general.CheckNPS();
        base.Death();
    }
}
