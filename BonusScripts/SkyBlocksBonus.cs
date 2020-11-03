﻿public class SkyBlocksBonus : Bonus
{
    public float duration = 30;
    public bool isBreakable = false;

    public override void ActivateBonus()
    {
        for (int i = 0; i < GameController.instance.blocks.Length; i++)
            GameController.instance.blocks[i].ActivateBlocks(duration, isBreakable);
        base.ActivateBonus();
    }
}